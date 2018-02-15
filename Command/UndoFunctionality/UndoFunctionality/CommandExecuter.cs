namespace UndoFunctionality
{
    /// <summary>
    /// A facade between the caller and the commands
    /// </summary>
    class CommandExecuter
    {
        public readonly CommandHistory CommandHistory = new CommandHistory();

        public void ExecuteCommand(ICommand command, bool addToHistory = true)
        {
            command.Execute();

            if (addToHistory)
                CommandHistory.Remember(command);
        }
    }
}
