/*
order: 20
title: News Search
slug: news-search

Shows how to search Google News for recent articles.
*/

namespace Serper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task NewsSearch()
    {
        using var client = GetAuthenticatedClient();

        //// Search Google News for recent articles on a topic.
        var response = await client.NewsSearchAsync(new BaseSearchRequest
        {
            Q = "technology startups 2026",
            Num = 5,
        });

        //// The response contains a list of news articles with titles, sources, and dates.
        response.News.Should().NotBeNull();
        response.News!.Count.Should().BeGreaterThan(0);

        foreach (var article in response.News)
        {
            Console.WriteLine($"{article.Title}");
            Console.WriteLine($"    Source: {article.Source}, Date: {article.Date}");
            Console.WriteLine($"    {article.Link}");
        }
    }
}
