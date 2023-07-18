using UnityEngine;
using UnityEngine.InputSystem;

public class BlackSmithController : BasePropsController
{
    [SerializeField] private GameObject _textPlate;

    private InputAction TestInputAction;
    private PlayerInput _playerInput;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            _playerInput = collider.gameObject.GetComponent<PlayerInput>();
            TestInputAction = _playerInput.actions.FindAction("Action");
            TestInputAction.performed += Action;
            ShowPlate(_textPlate);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            TestInputAction.performed -= Action;
            HidePlate(_textPlate);
        }
    }

    public override void Action(InputAction.CallbackContext context)
    {
        HidePlate(_textPlate);
    }
}