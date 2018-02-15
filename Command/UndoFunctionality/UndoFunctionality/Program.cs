using System;

namespace UndoFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandExecuter = new CommandExecuter();

            // Paste the mock clipboard text
            for (var i = 0; i < 4; i++)
            {
                commandExecuter.ExecuteCommand(new PasteCommand());
            }

            // Do too many undo's to check for exceptions
            for (var i = 0; i < 8; i++)
            {
                commandExecuter.CommandHistory.Undo();
            }

            // Test redo
            for (var i = 0; i < 2; i++)
            {
                commandExecuter.CommandHistory.Redo();
            }

            Console.WriteLine(MockTextField.Text);

            Console.ReadLine();
        }
    }
}
