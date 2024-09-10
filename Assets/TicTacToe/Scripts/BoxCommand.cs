namespace TicTacToe.Scripts
{
    public class BoxCommand : ICommand
    {
        
        public readonly Box Box;
        public readonly GameManager.Player Player;

        public BoxCommand(Box box, GameManager.Player player)
        {
            this.Box = box;
            this.Player = player;
        }


        public void Execute()
        {
            Box.OnCommandExecute();
        }

        public void Undo()
        {
            Box.OnCommandUndo();
        }
    }
}