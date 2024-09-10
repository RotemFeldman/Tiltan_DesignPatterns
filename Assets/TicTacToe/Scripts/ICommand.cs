namespace TicTacToe.Scripts
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}