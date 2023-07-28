using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackAreaController : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerController _playerController;
    private InputAction TestInputAction;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            TestInputAction = _playerInput.actions.FindAction("Attack");
            TestInputAction.performed += _playerController.OnAttack;
            Debug.Log("Enemy in area");
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            TestInputAction.performed -= _playerController.OnAttack;
            Debug.Log("Enemy out of area");
        }
    }
}
