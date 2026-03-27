/*
order: 40
title: Search Tool
slug: search-tool

Shows how to use Serper as an AIFunction tool with any IChatClient.
*/

namespace Serper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsSearchTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a Google search tool from the Serper client for use with any IChatClient.
        var tool = client.AsSearchTool(numResults: 3);
        tool.Name.Should().Be("GoogleSearch");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
