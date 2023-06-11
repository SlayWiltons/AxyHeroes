using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ChestController : MonoBehaviour
{
    private InputAction TestInputAction;
    private PlayerInput _playerInput;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Income" + collider.gameObject.name);
        _playerInput = collider.gameObject.GetComponent<PlayerInput>();
        TestInputAction = _playerInput.actions.FindAction("Action");
        TestInputAction.performed += Action;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Exit" + collider.gameObject.name);
    }

    private void Action(InputAction.CallbackContext context)
    {
        Debug.Log("Open the chest?");
    }
}