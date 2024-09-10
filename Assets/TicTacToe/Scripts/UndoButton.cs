using System;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Scripts
{
    public class UndoButton : MonoBehaviour
    {
        [SerializeField] Button undoButton;

        private void Update()
        {
            undoButton.interactable = CommandInvoker.GetUndoStackSize() > 0;
        }

        public void Undo()
        {
            CommandInvoker.UndoCommand();
        }
    }
}