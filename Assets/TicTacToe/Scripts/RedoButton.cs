using System;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Scripts
{
    public class RedoButton : MonoBehaviour
    {
        [SerializeField] Button redoButton;

        private void Update()
        {
            redoButton.interactable = CommandInvoker.GetRedoStackSize() > 0;
        }

        public void Redo()
        {
            CommandInvoker.RedoCommand();
        }
    }
}