namespace Serper.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SerperClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SERPER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SERPER_API_KEY environment variable is not found.");

        var client = new SerperClient(apiKey);
        
        return client;
    }
}
