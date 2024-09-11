using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TicTacToe.Scripts
{
    public class BoxPresenter : MonoBehaviour
    {
        
        [SerializeField] private Image XPiece;
        [SerializeField] private Image OPiece;
        [SerializeField] private Box _box;

      
        
        

        private void OnEnable()
        {
            _box.OnPieceChanged.AddListener(UpdatePiece);
        }

        private void OnValidate()
        {
            if(_box == null)
                _box = GetComponent<Box>();
        }

        private void UpdatePiece(Box.Piece piece)
        {
            switch (piece)
            {
                case Box.Piece.X:
                    if(transform.childCount == 0)
                        Instantiate( XPiece, transform.position, Quaternion.identity, transform);
                    break;
                case Box.Piece.O:
                    if(transform.childCount == 0)
                        Instantiate( OPiece, transform.position, Quaternion.identity, transform);
                    break;
                case Box.Piece.None:
                    if(transform.childCount > 0)
                        Destroy(transform.GetChild(0).gameObject);
                    break;
                default:
                    Debug.LogError("Box piece " + piece + " not supported");
                    break;
            }
        }

        
    }

    
}