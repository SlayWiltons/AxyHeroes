using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortretGenderNameModule : MenuModule
{
    [SerializeField] private GameObject classChooseModule;
    [SerializeField] private Image _portret;
    [SerializeField] private List<Texture> _malePortrets;
    [SerializeField] private List<Sprite> _femalePortrets;
    private int _portretId = 0;

    public void ChooseMalePortrets()
    {
        
    }

    public void ChooseFemalePortrets()
    {

    }

    public void OnEnable()
    {
        _portret.sprite = _femalePortrets[_portretId];
    }

    public void NextPortret()
    {
        ChangePortret(1);
    }

    public void PrevPortret()
    {
        ChangePortret(-1);
    }

    public override void NextModule()
    {
        classChooseModule.SetActive(true);
        gameObject.SetActive(false);
    }

    private void ChangePortret(int delta)
    {
        _portretId += delta;
        if (_femalePortrets.Count - 1 < _portretId)
        {
            _portretId = 0;
        }
        else if (_portretId < 0)
        {
            _portretId = _femalePortrets.Count - 1;
        }
        _portret.sprite = _femalePortrets[_portretId];
    }
}
