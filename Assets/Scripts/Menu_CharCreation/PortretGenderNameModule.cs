using System.Collections.Generic;
using TMPro;
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
    [SerializeField] private TMP_InputField _characterNameInput;
    [SerializeField] private List<Sprite> _malePortrets;
    [SerializeField] private List<Sprite> _femalePortrets;
    private Color _selectedColor = Color.green;
    private Color _normalColor = Color.white;
    private int _portretId = 0;
    private bool isMaleChoose = false;
    private bool isFemaleChoose = false;
    private string _characterName;

    public string Name()
    {
        return _characterName;
    }

    public void ChooseMalePortrets()
    {
        if (_malePortrets.Count != 0)
        {
            isMaleChoose = true;
            isFemaleChoose = false;
            ChangeColor(_maleButton, _selectedColor);
            ChangeColor(_femaleButton, _normalColor);
        }
        else
        {
            ChangeColor(_maleButton, _normalColor);
            isMaleChoose = false;
            isFemaleChoose = false;
        }
    }

    public void ChooseFemalePortrets()
    {
        if (_femalePortrets.Count != 0)
        {
            isFemaleChoose = true;
            isMaleChoose = false;
            ChangeColor(_femaleButton, _selectedColor);
            ChangeColor(_maleButton, _normalColor);
        }
        else
        {
            ChangeColor(_femaleButton, _normalColor);
            isMaleChoose = false;
            isFemaleChoose = false;
        }
    }

    public void OnEnable()
    {
        ChooseMalePortrets();
        if (isMaleChoose == true)
        {
            _portret.sprite = _malePortrets[_portretId];
        }
        else
        {
            ChooseFemalePortrets();
            if (isFemaleChoose == true)
            {
                _portret.sprite = _femalePortrets[_portretId];
            }
        }
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
        _characterName = _characterNameInput.text;
        classChooseModule.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Exit()
    {
        
    }

    private void ChangeColor(Button button, Color color)
    {
        ColorBlock colors = button.GetComponent<Button>().colors;
        colors.highlightedColor = color;
        colors.normalColor = color;
        colors.pressedColor = color;
        colors.selectedColor = color;
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
