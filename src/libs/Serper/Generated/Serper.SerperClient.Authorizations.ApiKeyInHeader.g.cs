
#nullable enable

namespace Serper
{
    public sealed partial class SerperClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Serper.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-KEY",
                Value = apiKey,
            });
        }
    }
}