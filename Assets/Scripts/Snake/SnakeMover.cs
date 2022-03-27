using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class SnakeMover
{
    private float _speed;
    private Rigidbody _rigidbody;
    private float _steerDirection;
    private Transform _transform;

    private float _turnSpeed=100;

    public SnakeMover(Rigidbody rigidbody, PlayerInput input, float speed)
    {
        _rigidbody = rigidbody;
        _transform = _rigidbody.transform;
        _speed = speed;

        input.Snake.Rotate.performed += OnInput;
        input.Snake.Rotate.canceled += OnInput;
    }

    public void HandleMovement()
    {
        _transform.Translate(Vector3.forward*_speed*Time.deltaTime);
    }

    public void HandleRotation()
    {
        _transform.Rotate(Vector3.up*_steerDirection*Time.deltaTime*_turnSpeed);
    }

    private void OnInput(InputAction.CallbackContext ctx)
    {
        _steerDirection = ctx.ReadValue<float>();
    }
}