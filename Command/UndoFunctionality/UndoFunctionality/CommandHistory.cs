using System.Collections.Generic;

namespace UndoFunctionality
{
    class CommandHistory
    {
        private readonly int _maxHistoryLength = 10;
        private readonly List<ICommand> _history = new List<ICommand>();

        private int _currentHistoryIndex = 0;

        public void Remember(ICommand command)
        {
            _history.Insert(0, command);
            _currentHistoryIndex = 0;
        }

        public void Forget(ICommand command)
        {
            _history.Remove(command);
        }

        public void Undo()
        {
            if (_currentHistoryIndex > _history.Count - 1)
                return; // Nothing to undo

            _history[_currentHistoryIndex].Unexecute();
            _currentHistoryIndex++;
        }

        public void Redo()
        {
            if (_currentHistoryIndex == 0)
                return; // Nothing to redo

            _currentHistoryIndex--;
            _history[_currentHistoryIndex].Execute();
        }
    }
}
