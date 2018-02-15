namespace UndoFunctionality
{
    abstract class Command : ICommand
    {
        public abstract void Execute();

        public abstract void Unexecute();
    }
}
