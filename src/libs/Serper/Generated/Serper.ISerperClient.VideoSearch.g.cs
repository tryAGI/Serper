#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Video Search<br/>
        /// Search Google for video results from YouTube and other video platforms.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.VideoSearchResponse> VideoSearchAsync(

            global::Serper.VideoSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Search<br/>
        /// Search Google for video results from YouTube and other video platforms.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.VideoSearchResponse> VideoSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}