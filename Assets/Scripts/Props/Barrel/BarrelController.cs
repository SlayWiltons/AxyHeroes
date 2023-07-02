using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class BarrelController : BasePropsController
{
    [SerializeField] private GameObject _textPlate;

    private InputAction TestInputAction;
    private PlayerInput _playerInput;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        _playerInput = collider.gameObject.GetComponent<PlayerInput>();
        TestInputAction = _playerInput.actions.FindAction("Action");
        TestInputAction.performed += Action;
        ShowPlate(_textPlate);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        TestInputAction.performed -= Action;
        HidePlate(_textPlate);
    }

    public override void Action(InputAction.CallbackContext context)
    {
        HidePlate(_textPlate);
        gameObject.SetActive(false);
    }
}