#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Places Search<br/>
        /// Search Google Maps/Places for local businesses and points of interest.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.PlacesSearchResponse> PlacesSearchAsync(

            global::Serper.PlacesSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Places Search<br/>
        /// Search Google Maps/Places for local businesses and points of interest.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.PlacesSearchResponse> PlacesSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}