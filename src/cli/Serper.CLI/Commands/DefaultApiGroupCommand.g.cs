#nullable enable

using System.CommandLine;

namespace Serper.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(AutocompleteCommandApiCommand.Create());
                         command.Subcommands.Add(ImageSearchCommandApiCommand.Create());
                         command.Subcommands.Add(NewsSearchCommandApiCommand.Create());
                         command.Subcommands.Add(PatentSearchCommandApiCommand.Create());
                         command.Subcommands.Add(PlacesSearchCommandApiCommand.Create());
                         command.Subcommands.Add(ScholarSearchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCommandApiCommand.Create());
                         command.Subcommands.Add(ShoppingSearchCommandApiCommand.Create());
                         command.Subcommands.Add(VideoSearchCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}