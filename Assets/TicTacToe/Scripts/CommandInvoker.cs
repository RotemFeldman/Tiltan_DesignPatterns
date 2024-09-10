using System.Collections.Generic;

namespace TicTacToe.Scripts
{
    public static class CommandInvoker
    {
        private static Stack<ICommand> _undoStack = new Stack<ICommand>();
        private static Stack<ICommand> _redoStack = new Stack<ICommand>();

        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
            
            GameManager.Instance.PassTurn();
        }

        public static void UndoCommand()
        {
            if (_undoStack.Count > 0)
            {
                ICommand command = _undoStack.Pop();
                _redoStack.Push(command);
                command.Undo();
                
                GameManager.Instance.PassTurn();
            }
        }

        public static void RedoCommand()
        {
            if (_redoStack.Count > 0)
            {
                ICommand command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
                
                GameManager.Instance.PassTurn();
            }
        }

        public static int GetUndoStackSize()
        {
            return _undoStack.Count;
        }

        public static int GetRedoStackSize()
        {
            return _redoStack.Count;
        }
        
        
        
    }
}