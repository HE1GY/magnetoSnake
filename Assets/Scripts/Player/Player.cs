using System;
using UnityEngine;


public class Player : MonoBehaviour
{
        [SerializeField] private Transform _camera;
        [SerializeField] private LandScope _landScope;
        
        private MouseLook _mouseLook;
        private PlayerInput _playerInput;
        private PlayerMove _playerMove;
        private LandScopePlacer _landScopePlacer;
        
        private Rigidbody _rigidbody;


        private void Awake()
        {
                _rigidbody = GetComponent<Rigidbody>();
                
                _playerInput = new PlayerInput();
                _mouseLook = new MouseLook(transform, _camera, _playerInput);
                _landScopePlacer = new LandScopePlacer(_camera,_landScope,_playerInput);
                _playerMove = new PlayerMove(_rigidbody);

                _landScopePlacer.Jump += _playerMove.Jump;
        }


        private void OnEnable()
        {
                _playerInput.Enable();
        }

        private void OnDisable()
        {
                _playerInput.Disable();        
        }

        private void Update()
        {
                _landScopePlacer.HandleLandScopePlacing();
        }
}