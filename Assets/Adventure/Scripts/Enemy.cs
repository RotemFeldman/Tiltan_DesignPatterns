using UnityEngine;

namespace Adventure.Scripts
{
    public class Enemy : MonoBehaviour
    {
        
        private Transform _target;
        private float _speed = 2f;
        
        void Start()
        {
            _target = Player.Instance.transform;
        }

        
        void Update()
        {
            var step = _speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _target.position, step);
            
            if (Vector3.Distance(transform.position, _target.position) < 0.001f)
            {
                _target.position *= -1.0f;
            }
        }
    }
}
