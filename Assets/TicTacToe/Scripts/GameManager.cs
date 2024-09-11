using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TicTacToe.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
    
        [SerializeField] public Player currentPlayer;
        [SerializeField] private TextMeshProUGUI playerXScoreText;
        [SerializeField] private TextMeshProUGUI playerOScoreText;
        
        [HideInInspector] public List<Box> boxes = new List<Box>();
        
        private int _playerXScore;
        private int _playerOScore;

        
    
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

        public void AddScore(string player)
        {
            switch (player)
            {
                case "X":
                    _playerXScore++;
                    playerXScoreText.text = "X score: "+ _playerXScore.ToString();
                    break;
                case "O":
                    _playerOScore++;
                    playerOScoreText.text = "O score: "+ _playerOScore.ToString();
                    break;
            }
            
            ClearBoard();
        }

        private void ClearBoard()
        {
            foreach (var box in boxes)
            {
                box.ChangePiece(Box.Piece.None);
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
