using UnityEngine;
using UnityEngine.InputSystem;

public class BasePropsController : MonoBehaviour
{
    public virtual void Action(InputAction.CallbackContext context)
    {

    }

    public void ShowPlate(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void HidePlate(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
