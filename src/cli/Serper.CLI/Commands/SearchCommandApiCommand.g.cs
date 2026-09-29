#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Serper.CLI.Commands;

internal static partial class SearchCommandApiCommand
{
    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Search query string.",
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

    private static Option<global::Serper.SearchRequestVariant2Type?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Type of search to perform.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Serper.SearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Serper.SearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"search", @"Google Search
Perform a Google web search. Returns organic results, knowledge graph, answer box,
people also ask, and related searches.
");
                        command.Options.Add(Q);
                        command.Options.Add(Gl);
                        command.Options.Add(Hl);
                        command.Options.Add(Num);
                        command.Options.Add(Page);
                        command.Options.Add(Autocorrect);
                        command.Options.Add(Type);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Serper.SearchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Serper.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var q = (CliRuntime.WasSpecified(parseResult, Q)
                            ? parseResult.GetValue(Q)
                            : __requestBase.Value1?.Q)
                            ?? throw new CliException(@"Specify q or include it in the base request body.");
                        var gl = CliRuntime.WasSpecified(parseResult, Gl) ? parseResult.GetValue(Gl) : (__requestBase is { } __GlBaseValue ? __GlBaseValue.Value1?.Gl : default);
                        var hl = CliRuntime.WasSpecified(parseResult, Hl) ? parseResult.GetValue(Hl) : (__requestBase is { } __HlBaseValue ? __HlBaseValue.Value1?.Hl : default);
                        var num = CliRuntime.WasSpecified(parseResult, Num) ? parseResult.GetValue(Num) : (__requestBase is { } __NumBaseValue ? __NumBaseValue.Value1?.Num : default);
                        var page = CliRuntime.WasSpecified(parseResult, Page) ? parseResult.GetValue(Page) : (__requestBase is { } __PageBaseValue ? __PageBaseValue.Value1?.Page : default);
                        var autocorrect = CliRuntime.WasSpecified(parseResult, Autocorrect) ? parseResult.GetValue(Autocorrect) : (__requestBase is { } __AutocorrectBaseValue ? __AutocorrectBaseValue.Value1?.Autocorrect : default);
                        var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Value2?.Type : default);
                        var __component1 = __requestBase.Value1 ?? new global::Serper.BaseSearchRequest { Q = q! };
                        __component1.Q = q;
                        __component1.Gl = gl;
                        __component1.Hl = hl;
                        __component1.Num = num;
                        __component1.Page = page;
                        __component1.Autocorrect = autocorrect;

                        var __component2 = __requestBase.Value2 ?? new global::Serper.SearchRequestVariant2();
                        __component2.Type = type;

                        if (CliRuntime.WasSpecified(parseResult, Type))
                        {
                            __component1.AdditionalProperties?.Remove(@"type");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Q))
                        {
                            __component2.AdditionalProperties?.Remove(@"q");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Gl))
                        {
                            __component2.AdditionalProperties?.Remove(@"gl");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Hl))
                        {
                            __component2.AdditionalProperties?.Remove(@"hl");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Num))
                        {
                            __component2.AdditionalProperties?.Remove(@"num");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Page))
                        {
                            __component2.AdditionalProperties?.Remove(@"page");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Autocorrect))
                        {
                            __component2.AdditionalProperties?.Remove(@"autocorrect");
                        }
                        var request = new global::Serper.SearchRequest(
                            __component1, __component2);

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SearchAsync(

                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Serper.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}