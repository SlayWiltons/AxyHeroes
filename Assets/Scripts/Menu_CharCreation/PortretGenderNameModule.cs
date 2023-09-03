using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class PortretGenderNameModule : MenuModule
{
    [SerializeField] private GameObject nextModule;
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

    public bool IsMale()
    {
        return isMaleChoose;
    }

    public bool IsFemale()
    {
        return isFemaleChoose;
    }

    public void ChooseMalePortrets()
    {
        isMaleChoose = true;
        isFemaleChoose = false;
        ChangeColor(_maleButton, _selectedColor);
        ChangeColor(_femaleButton, _normalColor);
        _portret.sprite = _malePortrets[0];
    }

    public void ChooseFemalePortrets()
    {
        isFemaleChoose = true;
        isMaleChoose = false;
        ChangeColor(_femaleButton, _selectedColor);
        ChangeColor(_maleButton, _normalColor);
        _portret.sprite = _femalePortrets[0];
    }

    public void OnEnable()
    {
        ChooseMalePortrets();
    }

    public void NextPortret()
    {
        if (isMaleChoose)
        {
            ChangePortret(1, _malePortrets);
        }
        else ChangePortret(1, _femalePortrets);
    }

    public void PrevPortret()
    {
        if (isMaleChoose)
        {
            ChangePortret(-1, _malePortrets);
        }
        else ChangePortret(-1, _femalePortrets);
    }

    public override void NextModule()
    {
        _characterName = _characterNameInput.text;
        nextModule.SetActive(true);
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

    private void ChangePortret(int delta, List<Sprite> portretsList)
    {
        _portretId += delta;
        if (portretsList.Count - 1 < _portretId)
        {
            _portretId = 0;
        }
        else if (_portretId < 0)
        {
            _portretId = portretsList.Count - 1;
        }
        _portret.sprite = portretsList[_portretId];
    }
}
