using Microsoft.Extensions.AI;

namespace Serper;

/// <summary>
/// Extensions for using SerperClient as an MEAI tool with any IChatClient.
/// </summary>
public static class SerperToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Serper Google search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Serper client to use for searches.</param>
    /// <param name="numResults">Maximum number of search results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchTool(
        this SerperClient client,
        int numResults = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.SearchAsync(
                    request: new BaseSearchRequest
                    {
                        Q = query,
                        Num = numResults,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response);
            },
            name: "GoogleSearch",
            description: "Searches Google for current information on a given query. Returns relevant results with titles, URLs, and text snippets.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Serper Google news search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Serper client to use for news searches.</param>
    /// <param name="numResults">Maximum number of news results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsNewsTool(
        this SerperClient client,
        int numResults = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.NewsSearchAsync(
                    request: new BaseSearchRequest
                    {
                        Q = query,
                        Num = numResults,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatNewsResponse(response);
            },
            name: "GoogleNewsSearch",
            description: "Searches Google News for recent news articles on a given query. Returns news results with titles, sources, dates, and snippets.");
    }

    private static string FormatSearchResponse(SearchResponse response)
    {
        var parts = new List<string>();

        if (response.AnswerBox is { } answerBox)
        {
            if (!string.IsNullOrWhiteSpace(answerBox.Answer))
            {
                parts.Add($"Answer: {answerBox.Answer}");
            }
            else if (!string.IsNullOrWhiteSpace(answerBox.Snippet))
            {
                parts.Add($"Answer: {answerBox.Snippet}");
            }
        }

        if (response.Organic is { Count: > 0 })
        {
            parts.Add("Sources:");
            foreach (var result in response.Organic)
            {
                var entry = $"- [{result.Title}]({result.Link})";
                if (!string.IsNullOrWhiteSpace(result.Snippet))
                {
                    entry += $": {result.Snippet}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatNewsResponse(NewsSearchResponse response)
    {
        var parts = new List<string>();

        if (response.News is { Count: > 0 })
        {
            parts.Add("News:");
            foreach (var result in response.News)
            {
                var entry = $"- [{result.Title}]({result.Link})";
                if (!string.IsNullOrWhiteSpace(result.Source))
                {
                    entry += $" ({result.Source})";
                }
                if (!string.IsNullOrWhiteSpace(result.Date))
                {
                    entry += $" [{result.Date}]";
                }
                if (!string.IsNullOrWhiteSpace(result.Snippet))
                {
                    entry += $": {result.Snippet}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }
}
