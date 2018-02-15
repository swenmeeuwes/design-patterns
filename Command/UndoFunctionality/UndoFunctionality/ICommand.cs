namespace UndoFunctionality
{
    interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
