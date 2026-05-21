#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.SearchResponse> SearchAsync(

            global::Serper.SearchRequest request,
            global::Serper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.AutoSDKHttpResponse<global::Serper.SearchResponse>> SearchAsResponseAsync(

            global::Serper.SearchRequest request,
            global::Serper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.SearchResponse> SearchAsync(
            global::Serper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}