#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Serper.CLI.Commands;

internal static partial class AutocompleteCommandApiCommand
{
    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Partial query string for autocomplete suggestions.",
        Required = true,
    };

    private static Option<string?> Gl { get; } = new(
        name: @"--gl")
    {
        Description = @"Country code for localized suggestions (ISO 3166-1 alpha-2).",
    };

    private static Option<string?> Hl { get; } = new(
        name: @"--hl")
    {
        Description = @"Language code for the interface language (ISO 639-1).",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Serper.AutocompleteResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Serper.AutocompleteResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"autocomplete", @"Autocomplete
Get Google autocomplete suggestions for a partial query.");
                        command.Options.Add(Q);
                        command.Options.Add(Gl);
                        command.Options.Add(Hl);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Serper.AutocompleteRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Serper.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var q = parseResult.GetRequiredValue(Q);
                        var gl = CliRuntime.WasSpecified(parseResult, Gl) ? parseResult.GetValue(Gl) : (__requestBase is { } __GlBaseValue ? __GlBaseValue.Gl : default);
                        var hl = CliRuntime.WasSpecified(parseResult, Hl) ? parseResult.GetValue(Hl) : (__requestBase is { } __HlBaseValue ? __HlBaseValue.Hl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AutocompleteAsync(
                                    q: q,
                                    gl: gl,
                                    hl: hl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Serper.SourceGenerationContext.Default,
                                        @"Suggestions",
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