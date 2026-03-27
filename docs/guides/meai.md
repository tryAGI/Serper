# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Serper SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models Google search and news search capabilities.

## Installation

```bash
dotnet add package Serper
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchTool(numResults)` | `GoogleSearch` | Searches Google for current information on a query |
| `AsNewsTool(numResults)` | `GoogleNewsSearch` | Searches Google News for recent news articles |

## Usage

```csharp
using Serper;
using Microsoft.Extensions.AI;

var serper = new SerperClient(apiKey: Environment.GetEnvironmentVariable("SERPER_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        serper.AsSearchTool(numResults: 5),
        serper.AsNewsTool(numResults: 5),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What happened in tech news today?"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

### AsSearchTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `numResults` | `int` | `5` | Maximum number of search results to return |

### AsNewsTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `numResults` | `int` | `5` | Maximum number of news results to return |
