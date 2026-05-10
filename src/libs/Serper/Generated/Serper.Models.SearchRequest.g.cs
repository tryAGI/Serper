#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Serper
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchRequest : global::System.IEquatable<SearchRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Serper.BaseSearchRequest? Base { get; init; }
#else
        public global::Serper.BaseSearchRequest? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Serper.BaseSearchRequest? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Serper.SearchRequestVariant2? SearchRequestVariant2 { get; init; }
#else
        public global::Serper.SearchRequestVariant2? SearchRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchRequestVariant2))]
#endif
        public bool IsSearchRequestVariant2 => SearchRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Serper.SearchRequestVariant2? value)
        {
            value = SearchRequestVariant2;
            return IsSearchRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchRequest(global::Serper.BaseSearchRequest value) => new SearchRequest((global::Serper.BaseSearchRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Serper.BaseSearchRequest?(SearchRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SearchRequest(global::Serper.BaseSearchRequest? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchRequest FromBase(global::Serper.BaseSearchRequest? value) => new SearchRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchRequest(global::Serper.SearchRequestVariant2 value) => new SearchRequest((global::Serper.SearchRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Serper.SearchRequestVariant2?(SearchRequest @this) => @this.SearchRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SearchRequest(global::Serper.SearchRequestVariant2? value)
        {
            SearchRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchRequest FromSearchRequestVariant2(global::Serper.SearchRequestVariant2? value) => new SearchRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchRequest(
            global::Serper.BaseSearchRequest? @base,
            global::Serper.SearchRequestVariant2? searchRequestVariant2
            )
        {
            Base = @base;
            SearchRequestVariant2 = searchRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SearchRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSearchRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Serper.BaseSearchRequest, TResult>? @base = null,
            global::System.Func<global::Serper.SearchRequestVariant2, TResult>? searchRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsSearchRequestVariant2 && searchRequestVariant2 != null)
            {
                return searchRequestVariant2(SearchRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Serper.BaseSearchRequest>? @base = null,

            global::System.Action<global::Serper.SearchRequestVariant2>? searchRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSearchRequestVariant2)
            {
                searchRequestVariant2?.Invoke(SearchRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Serper.BaseSearchRequest>? @base = null,
            global::System.Action<global::Serper.SearchRequestVariant2>? searchRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSearchRequestVariant2)
            {
                searchRequestVariant2?.Invoke(SearchRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Serper.BaseSearchRequest),
                SearchRequestVariant2,
                typeof(global::Serper.SearchRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SearchRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Serper.BaseSearchRequest?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Serper.SearchRequestVariant2?>.Default.Equals(SearchRequestVariant2, other.SearchRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchRequest obj1, SearchRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchRequest obj1, SearchRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchRequest o && Equals(o);
        }
    }
}
