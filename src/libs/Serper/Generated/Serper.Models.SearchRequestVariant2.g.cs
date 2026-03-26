
#nullable enable

namespace Serper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestVariant2
    {
        /// <summary>
        /// Type of search to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Serper.JsonConverters.SearchRequestVariant2TypeJsonConverter))]
        public global::Serper.SearchRequestVariant2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of search to perform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestVariant2(
            global::Serper.SearchRequestVariant2Type? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestVariant2" /> class.
        /// </summary>
        public SearchRequestVariant2()
        {
        }
    }
}