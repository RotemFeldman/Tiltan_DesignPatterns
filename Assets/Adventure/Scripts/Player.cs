using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Adventure.Scripts
{
    public class Player : MonoBehaviour
    {
        public static Player Instance;
        
        [SerializeField] TextMeshProUGUI scoretext;

        private int _score;
        
        private List<Pickup> _pickups = new List<Pickup>();

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

        public void AddPickup(Pickup pickup)
        {
            _pickups.Add(pickup);
            pickup.OnPickup.AddListener(CollectPickup);
        }

        private void CollectPickup(Pickup pickup)
        {
            _score++;
            scoretext.text = "Pickups Collected: " + _score;
            
            _pickups.Remove(pickup);
            pickup.OnPickup.RemoveListener(CollectPickup);
        }
        
        
        
        
    }
}