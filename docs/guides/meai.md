# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Serper SDK provides `AIFunction` tool wrappers from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), allowing you to use Google Search and Google News as tools with any `IChatClient`.

## Installation

```bash
dotnet add package Serper
```

## Search Tool

Use `AsSearchTool()` to create an `AIFunction` that searches Google:

```csharp
using Serper;
using Microsoft.Extensions.AI;

var serperClient = new SerperClient(apiKey: Environment.GetEnvironmentVariable("SERPER_API_KEY")!);

var searchTool = serperClient.AsSearchTool(numResults: 5);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [searchTool],
};

var response = await chatClient.GetResponseAsync(
    "What happened in tech news today?",
    options);
```

## News Tool

Use `AsNewsTool()` to search Google News for recent articles:

```csharp
var newsTool = serperClient.AsNewsTool(numResults: 5);

var options = new ChatOptions
{
    Tools = [newsTool],
};
```

## Combining Tools

Both tools can be used together:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        serperClient.AsSearchTool(numResults: 5),
        serperClient.AsNewsTool(numResults: 5),
    ],
};
```

## Auth Note

The Serper SDK includes a `PrepareRequest` auth hook that automatically converts the standard `Authorization: Bearer` header to Serper's native `X-API-KEY` header format. No additional configuration is needed.
