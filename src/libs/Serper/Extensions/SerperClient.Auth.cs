#nullable enable

namespace Serper;

public partial class SerperClient
{
    // Serper uses "X-API-KEY" header instead of "Authorization: Bearer".
    // The generated code sends "Authorization: Bearer <key>" but Serper
    // expects the API key in the "X-API-KEY" header.
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("X-API-KEY", apiKey);
        }
    }
}
