/*
order: 10
title: Search
slug: search

Shows how to perform a Google web search.
*/

namespace Serper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Search()
    {
        using var client = GetAuthenticatedClient();

        //// Perform a Google web search using the Serper API.
        var response = await client.SearchAsync(new BaseSearchRequest
        {
            Q = "artificial intelligence latest news",
            Num = 5,
        });

        //// The response includes organic results, knowledge graph, and more.
        response.Organic.Should().NotBeNull();
        response.Organic!.Count.Should().BeGreaterThan(0);

        foreach (var result in response.Organic)
        {
            Console.WriteLine($"[{result.Position}] {result.Title}");
            Console.WriteLine($"    {result.Link}");
        }
    }
}
