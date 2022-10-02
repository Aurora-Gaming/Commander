namespace Commander;

internal class CommandException : Exception
{
    private const string UnspecifiedError = "There has been an error during execution of your command.";
    private const string NoPermissionError = "You don't have permission to use this command!";
    private const string AbortedError = "Command execution was stopped midway due to an error.";
    private const string CooldownError = "You must wait {0} seconds before you can use this command again.";
    private const string NotEnoughParameters = "You must at least supply {0} arguments.";

    private static string GetErrorMessage(CommandError error)
    {
        return error switch
        {
            CommandError.NoPermission => NoPermissionError,
            CommandError.Aborted => AbortedError,
            CommandError.Cooldown => CooldownError,
            CommandError.NotEnoughParameters => NotEnoughParameters,
            _ => UnspecifiedError,
        };
    }

    internal CommandException(string message) : base(message)
    {
    }

    internal CommandException(CommandError error, params object[] args)
      : this(string.Format(GetErrorMessage(error), args))
    {
    }
}
