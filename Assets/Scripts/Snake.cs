using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bodySegment;
    
    private SnakeMover _snakeMover;
    private Rigidbody _rigidbody;
    private PlayerInput _input;
    
    private Body _body;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _input = new PlayerInput();
        
        _snakeMover = new SnakeMover(_rigidbody,_input,_speed);
        _body = new Body(_bodySegment);
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
    
    private void Update()
    {
        _snakeMover.HandleMovement();
        _snakeMover.HandleRotation();
        _body.ScanMovePosition(transform.position);
    }
    
}