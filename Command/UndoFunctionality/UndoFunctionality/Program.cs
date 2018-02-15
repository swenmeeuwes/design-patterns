using System;

namespace UndoFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandExecuter = new CommandExecuter();
            commandExecuter.ExecuteCommand(new PasteCommand());
            commandExecuter.ExecuteCommand(new PasteCommand());
            commandExecuter.ExecuteCommand(new PasteCommand());

            commandExecuter.CommandHistory.Undo();

            commandExecuter.CommandHistory.Redo();
            commandExecuter.CommandHistory.Redo();

            Console.WriteLine(MockTextField.Text);

            Console.ReadLine();
        }
    }
}
