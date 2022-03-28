using UnityEngine;
using UnityEngine.InputSystem;

namespace Snake
{
    public class SnakeMover
    {
        private float _speed;
        private Rigidbody _rigidbody;
        private Transform _transform;

        private float _turnSpeed = 0.5f;
        private Vector3 _lookDirection;

        public SnakeMover(Rigidbody rigidbody, PlayerInput input, float speed)
        {
            _rigidbody = rigidbody;
            _transform = _rigidbody.transform;
            _speed = speed;
            
        }

        public void SetlookDirection(Vector3 lookDirection)
        {
            _lookDirection = lookDirection;
        }
        

        public void HandleMovement()
        {
            _transform.Translate(Vector3.forward*_speed*Time.deltaTime);
        }
        
        public void HandleRotation()
        {
            if (_lookDirection != Vector3.zero)
            {
                _lookDirection.y = 0;
                Quaternion lookDirection=Quaternion.LookRotation(_lookDirection);
                _transform.rotation=Quaternion.Slerp( _transform.rotation,lookDirection,Time.deltaTime*_turnSpeed);
            }
        }
        
    }
}