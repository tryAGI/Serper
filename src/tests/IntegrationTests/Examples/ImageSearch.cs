/*
order: 30
title: Image Search
slug: image-search

Shows how to search Google Images for image results.
*/

namespace Serper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageSearch()
    {
        using var client = GetAuthenticatedClient();

        //// Search Google Images for images matching a query.
        var response = await client.ImageSearchAsync(new BaseSearchRequest
        {
            Q = "northern lights aurora borealis",
            Num = 5,
        });

        //// The response contains image results with URLs, dimensions, and source info.
        response.Images.Should().NotBeNull();
        response.Images!.Count.Should().BeGreaterThan(0);

        foreach (var image in response.Images)
        {
            Console.WriteLine($"{image.Title}");
            Console.WriteLine($"    {image.ImageUrl} ({image.ImageWidth}x{image.ImageHeight})");
            Console.WriteLine($"    Source: {image.Domain}");
        }
    }
}
