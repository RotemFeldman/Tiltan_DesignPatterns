using UnityEngine;

namespace TicTacToe.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
    
        [SerializeField] public Player currentPlayer;

        
    
    
        public enum Player
        {
            X,O
        }
    
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void PassTurn()
        {
            if(currentPlayer == Player.X)
                currentPlayer = Player.O;
            else
            {
                currentPlayer = Player.X;
            }
        }
    }
}
