#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Serper.CLI.Commands;

internal static partial class ImageSearchCommandApiCommand
{
    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Search query string.",
        Required = true,
    };

    private static Option<string?> Gl { get; } = new(
        name: @"--gl")
    {
        Description = @"Country code for localized results (ISO 3166-1 alpha-2).",
    };

    private static Option<string?> Hl { get; } = new(
        name: @"--hl")
    {
        Description = @"Language code for the interface language (ISO 639-1).",
    };

    private static Option<int?> Num { get; } = new(
        name: @"--num")
    {
        Description = @"Number of results to return.",
    };

    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page number for pagination.",
    };

    private static Option<bool?> Autocorrect { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--autocorrect",
        description: @"Whether to autocorrect the query spelling.");

                    private static string FormatResponse(ParseResult parseResult, global::Serper.ImageSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Serper.ImageSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"image-search", @"Image Search
Search Google Images for image results.");
                        command.Options.Add(Q);
                        command.Options.Add(Gl);
                        command.Options.Add(Hl);
                        command.Options.Add(Num);
                        command.Options.Add(Page);
                        command.Options.Add(Autocorrect);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var q = parseResult.GetRequiredValue(Q);
                        var gl = parseResult.GetValue(Gl);
                        var hl = parseResult.GetValue(Hl);
                        var num = parseResult.GetValue(Num);
                        var page = parseResult.GetValue(Page);
                        var autocorrect = parseResult.GetValue(Autocorrect);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageSearchAsync(
                                    q: q,
                                    gl: gl,
                                    hl: hl,
                                    num: num,
                                    page: page,
                                    autocorrect: autocorrect,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Serper.SourceGenerationContext.Default,
                                        @"Images",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Serper.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}