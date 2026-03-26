#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Shopping Search<br/>
        /// Search Google Shopping for product listings and prices.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ShoppingSearchResponse> ShoppingSearchAsync(

            global::Serper.ShoppingSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Shopping Search<br/>
        /// Search Google Shopping for product listings and prices.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ShoppingSearchResponse> ShoppingSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}