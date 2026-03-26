#nullable enable

namespace Serper
{
    public partial interface ISerperClient
    {
        /// <summary>
        /// Scholar Search<br/>
        /// Search Google Scholar for academic papers, articles, theses, and citations.<br/>
        /// Supports filtering by year range and finding papers that cite a specific work.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Serper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ScholarSearchResponse> ScholarSearchAsync(

            global::Serper.ScholarSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scholar Search<br/>
        /// Search Google Scholar for academic papers, articles, theses, and citations.<br/>
        /// Supports filtering by year range and finding papers that cite a specific work.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Serper.ScholarSearchResponse> ScholarSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}