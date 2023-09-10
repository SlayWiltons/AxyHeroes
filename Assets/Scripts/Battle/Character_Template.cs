using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Template", menuName = "Character Template", order = 2)]
public class Character_Template : ScriptableObject
{
    [SerializeField] private bool _isCharacter;
    [SerializeField] private string _name;
    [SerializeField] private string _className;
    [SerializeField] private Sprite _portraitSprite;
    [SerializeField] private int _str;
    [SerializeField] private int _agi;
    [SerializeField] private int _int;
    [SerializeField] private int _end;
    [SerializeField] private int _wis;
    [SerializeField] private int _per;
    [SerializeField] private int _luc;

    public int GetSTR()
    {
        return _str;
    }

    public void SetSTR(int value)
    {
        _str = value;
    }
}
