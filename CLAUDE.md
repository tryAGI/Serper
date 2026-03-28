# CLAUDE.md — Serper SDK

## Overview

Auto-generated C# SDK for [Serper](https://serper.dev/) — Google search results API covering web search, news, images, videos, places, shopping, scholar, patents, and autocomplete.
**No public OpenAPI spec exists** — `openapi.yaml` was manually created from Serper API documentation.

## Build & Test

```bash
dotnet build Serper.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new SerperClient(apiKey); // SERPER_API_KEY env var
```

## Key Files

- `src/libs/Serper/openapi.yaml` — **Manually maintained** OpenAPI spec (no public spec from Serper)
- `src/libs/Serper/generate.sh` — Fixes auth scheme in local spec, runs autosdk (no download step)
- `src/libs/Serper/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** — `openapi.yaml` was manually created from serper.dev API docs
- All 9 endpoints are POST requests to `https://google.serper.dev`
- Auth: `--security-scheme ApiKey:Header:X-API-KEY` sends the key directly as the native header (no spec conversion or PrepareRequest hook needed)
