namespace Microsoft.ComponentDetection.Orchestrator.Commands;

using Spectre.Console.Cli;

/// <summary>
/// Intercepts all commands before they are executed.
/// </summary>
public class Interceptor : ICommandInterceptor
{
    /// <inheritdoc />
    public void Intercept(CommandContext context, CommandSettings settings)
    {
        return;
    }
}
