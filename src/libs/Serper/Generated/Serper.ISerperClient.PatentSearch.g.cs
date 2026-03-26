#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.PatentSearchResponse> PatentSearchAsync(

            global::Serper.PatentSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.PatentSearchResponse> PatentSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}