using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class PortretGenderNameModule : MenuModule
{
    [SerializeField] private GameObject classChooseModule;
    [SerializeField] private Image _portret;
    [SerializeField] private Button _maleButton;
    [SerializeField] private Button _femaleButton;
    [SerializeField] private List<Texture> _malePortrets;
    [SerializeField] private List<Sprite> _femalePortrets;
    private Color _selectedColor = Color.green;
    private Color _normalColor = Color.white;
    private int _portretId = 0;

    public void ChooseMalePortrets()
    {
        ChangeColor(_maleButton, _selectedColor);
        ChangeColor(_femaleButton, _normalColor);
    }

    public void ChooseFemalePortrets()
    {
        ChangeColor(_femaleButton, _selectedColor);
        ChangeColor(_maleButton, _normalColor);
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

    private void ChangeColor(Button button, Color color)
    {
        ColorBlock colors = button.GetComponent<Button>().colors;
        colors.highlightedColor = color;
        colors.normalColor = color;
        colors.pressedColor = color;
        button.GetComponent<Button>().colors = colors;
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
