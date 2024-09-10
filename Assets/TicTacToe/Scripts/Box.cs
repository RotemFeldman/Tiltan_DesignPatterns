using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TicTacToe.Scripts
{
    public class Box : MonoBehaviour, IPointerClickHandler
    {
        
        [SerializeField] private Image XPiece;
        [SerializeField] private Image OPiece;
        
        // input
        public void OnPointerClick(PointerEventData eventData)
        {
            if(transform.childCount == 0)
                CommandInvoker.ExecuteCommand(new BoxCommand(this,GameManager.Instance.currentPlayer));
        }

        
        //command
        public void OnCommandExecute()
        {
            Instantiate(GameManager.Instance.currentPlayer == GameManager.Player.X ? XPiece : OPiece, transform.position,
                Quaternion.identity, transform);
        }

        public void OnCommandUndo()
        {
            if(transform.childCount > 0)
                Destroy(transform.GetChild(0).gameObject);
        }
    }

    
}