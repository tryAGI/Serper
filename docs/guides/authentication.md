# Authentication

The Serper SDK uses API key authentication. The Serper API natively expects the key in the `X-API-KEY` header. The SDK handles this automatically -- you pass the API key as a Bearer token and a `PrepareRequest` hook converts it to the `X-API-KEY` header format.

You can obtain an API key from your [Serper dashboard](https://serper.dev/dashboard).

## Basic Usage

```csharp
using Serper;

var client = new SerperClient(apiKey: Environment.GetEnvironmentVariable("SERPER_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `SERPER_API_KEY` | Your Serper API key |
