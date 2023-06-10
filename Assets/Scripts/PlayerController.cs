using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector2 _moveDirection;

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
        Debug.Log("Move");
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Attack");
        }
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Action");
        }
    }

    private void Move(Vector2 direction)
    {
        float scaleMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, direction.y, 0);
        transform.position += moveDirection * scaleMoveSpeed;
    }

    private void FixedUpdate()
    {
        Move(_moveDirection);
    }
}
