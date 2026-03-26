#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Image Search<br/>
        /// Search Google Images for image results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ImageSearchResponse> ImageSearchAsync(

            global::Serper.ImageSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Search<br/>
        /// Search Google Images for image results.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ImageSearchResponse> ImageSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}