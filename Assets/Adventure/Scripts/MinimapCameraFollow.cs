using UnityEngine;

namespace Adventure.Scripts
{
    public class MinimapCameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform player;

 
        void Update()
        {
            Vector3 playerPos = player.position;
            playerPos.y = transform.position.y;
        
            transform.position = playerPos;
            
            
            transform.rotation = Quaternion.Euler(90f,player.eulerAngles.y,0f);
        }
    }
}
