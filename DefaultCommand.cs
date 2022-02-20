using Spectre.Console;
using Spectre.Console.Cli;

namespace Sample;

public sealed class DefaultCommand : Command
{
    private readonly IAnsiConsole _console;

    public DefaultCommand(IAnsiConsole console)
    {
        _console = console;
    }

    public override int Execute(CommandContext context)
    {
        _console.MarkupLine("[yellow]Hello[/] [blue]World[/]!");
        return 0;
    }
}