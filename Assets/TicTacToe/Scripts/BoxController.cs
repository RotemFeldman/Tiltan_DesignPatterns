using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TicTacToe.Scripts
{
    public class BoxController : MonoBehaviour , IPointerClickHandler
    {
        [SerializeField] private Box _box;

        private void OnValidate()
        {
            if(_box == null)
                _box = GetComponent<Box>();
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            _box.OnPointerClick();
        }
    }
}
