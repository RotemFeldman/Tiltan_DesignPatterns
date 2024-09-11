using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TicTacToe.Scripts
{
    public class Box : MonoBehaviour
    {
        public UnityEvent<Piece> OnPieceChanged;
        
        public Piece Contains = Piece.None;
        
        public enum Piece
        {
            X,O,None
        }

        private void Start()
        {
            GameManager.Instance.boxes.Add(this);
        }


        public void OnPointerClick()
        {
            if(transform.childCount == 0)
                CommandInvoker.ExecuteCommand(new BoxCommand(this,GameManager.Instance.currentPlayer));
        }

        public void ChangePiece(Piece newPiece)
        {
            Contains = newPiece;
            OnPieceChanged?.Invoke(Contains);
        }

        
        public void OnCommandExecute()
        {
            ChangePiece(GameManager.Instance.currentPlayer == GameManager.Player.X ? Piece.X : Piece.O);
        }

        public void OnCommandUndo()
        {
            ChangePiece(Piece.None);
        }
    }

    
}