using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Vector2 _moveDirection;

    [SerializeField]private InputActionReference _move;

    private void Update()
    {
        _moveDirection = _move.action.ReadValue<Vector2>();
    }
    
    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(_moveDirection.x * _moveSpeed, _moveDirection.y *  _moveSpeed);
    }
}
