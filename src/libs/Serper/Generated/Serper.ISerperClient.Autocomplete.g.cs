#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Autocomplete<br/>
        /// Get Google autocomplete suggestions for a partial query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.AutocompleteResponse> AutocompleteAsync(

            global::Serper.AutocompleteRequest request,
            global::Serper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Autocomplete<br/>
        /// Get Google autocomplete suggestions for a partial query.
        /// </summary>
        /// <param name="q">
        /// Partial query string for autocomplete suggestions.<br/>
        /// Example: apple
        /// </param>
        /// <param name="gl">
        /// Country code for localized suggestions (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </param>
        /// <param name="hl">
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.AutocompleteResponse> AutocompleteAsync(
            string q,
            string? gl = default,
            string? hl = default,
            global::Serper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}