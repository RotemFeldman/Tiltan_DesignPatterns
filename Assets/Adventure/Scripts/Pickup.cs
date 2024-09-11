using UnityEngine;
using UnityEngine.Events;

namespace Adventure.Scripts
{
    public class Pickup : MonoBehaviour
    {
        public UnityEvent<Pickup> OnPickup;


        private void Start()
        {
            Player.Instance.AddPickup(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                OnPickedUp();
            }
        }

        void OnPickedUp()
        {
            Debug.Log("Collected Pickup");
            OnPickup?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
