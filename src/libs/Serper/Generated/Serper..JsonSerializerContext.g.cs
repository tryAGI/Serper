
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Serper
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Serper.JsonConverters.SearchRequestVariant2TypeJsonConverter),

            typeof(global::Serper.JsonConverters.SearchRequestVariant2TypeNullableJsonConverter),

            typeof(global::Serper.JsonConverters.SearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.NewsSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.ImageSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.VideoSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.PlacesSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.ShoppingSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.ScholarSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.PatentSearchRequestJsonConverter),

            typeof(global::Serper.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.BaseSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.SearchRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.SearchRequestVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.NewsSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ImageSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.VideoSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PlacesSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ShoppingSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ScholarSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ScholarSearchRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PatentSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.AutocompleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.SearchParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.OrganicResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.Sitelink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.Sitelink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.KnowledgeGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.AnswerBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PeopleAlsoAskItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.RelatedSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.NewsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ImageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.VideoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PlaceResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ShoppingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ScholarResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.CitedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PatentResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.AutocompleteSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.OrganicResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.PeopleAlsoAskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.RelatedSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.NewsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.NewsSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ImageSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.VideoSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PlacesSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.PlaceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ShoppingSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.ShoppingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.ScholarSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.ScholarResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.PatentSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.PatentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Serper.AutocompleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Serper.AutocompleteSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.Sitelink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.OrganicResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.PeopleAlsoAskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.RelatedSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.NewsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.PlaceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.ShoppingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.ScholarResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.PatentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Serper.AutocompleteSuggestion>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}