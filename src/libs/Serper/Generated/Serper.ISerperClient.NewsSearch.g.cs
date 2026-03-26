#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// News Search<br/>
        /// Search Google News for recent articles and stories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.NewsSearchResponse> NewsSearchAsync(

            global::Serper.NewsSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// News Search<br/>
        /// Search Google News for recent articles and stories.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.NewsSearchResponse> NewsSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}