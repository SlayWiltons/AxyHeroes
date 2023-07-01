using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ChestController : MonoBehaviour
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
        HidePlate(_textPlate);
    }

    private void Action(InputAction.CallbackContext context)
    {
        HidePlate(_textPlate);
        gameObject.SetActive(false);
    }

    private void ShowPlate(GameObject plate)
    {
        plate.SetActive(true);
    }

    private void HidePlate(GameObject plate)
    {
        plate.SetActive(false);
    }
}