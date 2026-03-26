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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.SearchResponse> SearchAsync(

            global::Serper.SearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.SearchResponse> SearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}