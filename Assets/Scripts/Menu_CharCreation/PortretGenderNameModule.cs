using UnityEngine;

public class PortretGenderNameModule : MenuModule
{
    [SerializeField] private GameObject classChooseModule;

    public override void NextModule()
    {
        classChooseModule.SetActive(true);
        gameObject.SetActive(false);
    }
}
