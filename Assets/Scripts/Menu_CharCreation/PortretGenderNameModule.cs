using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortretGenderNameModule : MenuModule
{
    [SerializeField] private GameObject classChooseModule;
    [SerializeField] private Image _portret;
    [SerializeField] private List<Texture> _malePortrets;
    [SerializeField] private List<Sprite> _femalePortrets;

    public void OnEnable()
    {
        _portret.sprite = _femalePortrets[0];
    }

    public override void NextModule()
    {
        classChooseModule.SetActive(true);
        gameObject.SetActive(false);
    }
}
