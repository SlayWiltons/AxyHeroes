using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Class_Controller : MonoBehaviour
{
    [SerializeField] private Classes_Container _classesContainer;
    [SerializeField] private TMP_Text _freePointsText;
    [SerializeField] private TMP_Text _className;
    [SerializeField] private int _freePointBase;

    [SerializeField] private TMP_Text _classSTR;
    [SerializeField] private TMP_Text _classAGI;
    [SerializeField] private TMP_Text _classINT;
    [SerializeField] private TMP_Text _classEND;
    [SerializeField] private TMP_Text _classWIS;
    [SerializeField] private TMP_Text _classPER;
    [SerializeField] private TMP_Text _classLUC;

    [SerializeField] private List<GameObject> _plusButtons;
    [SerializeField] private List<GameObject> _minusButtons;

    private int _classesCount;
    private int _classId;
    private int _freePoints;

    private int _str;
    private int _agi;
    private int _int;
    private int _end;
    private int _wis;
    private int _per;
    private int _luc;

    private bool isClassesExist()
    {
        _classesCount = _classesContainer.ClassesCount();
        if (_classesCount != 0)
        {
            return true;
        }
        else return false;
    }

    private void Start()    //В будущем заменить на OnEnable
    {
        if (isClassesExist())
        {
            _classId = 0;
            SetClassName();
            SetAllAtributes();
        }

        _freePoints = _freePointBase;
        _freePointsText.text = _freePoints.ToString();
        if (_freePoints != 0)
        {
            for (int i = 0; i < _plusButtons.Count; i++)
            {
                _plusButtons[i].SetActive(true);
            }
        }
    }

    private void SetClassName()
    {
        _className.text = _classesContainer.CharacterClass(_classId).Name;
    }

    private void SetAllAtributes()
    {
        _str = _classesContainer.CharacterClass(_classId).Str;
        _agi = _classesContainer.CharacterClass(_classId).Agi;
        _int = _classesContainer.CharacterClass(_classId).Int;
        _end = _classesContainer.CharacterClass(_classId).End;
        _wis = _classesContainer.CharacterClass(_classId).Wis;
        _per = _classesContainer.CharacterClass(_classId).Per;
        _luc = _classesContainer.CharacterClass(_classId).Luc;

        SetAtributeValue(_classSTR, _str);
        SetAtributeValue(_classAGI, _agi);
        SetAtributeValue(_classINT, _int);
        SetAtributeValue(_classEND, _end);
        SetAtributeValue(_classWIS, _wis);
        SetAtributeValue(_classPER, _per);
        SetAtributeValue(_classLUC, _luc);
    }

    private void ChangeClass(int delta)
    {
        _classId += delta;
        if (_classId < 0)
        {
            _classId = _classesCount - 1;
        }
        else if (_classId > _classesCount - 1)
        {
            _classId = 0;
        }
        SetClassName();
        SetAllAtributes();
    }

    private void ChangePoints(int delta, int atribute, int atributeFromCharacterClass, int atributeId)  //0-str, 1-agi, 2-int, 3-end, 4-wis, 5-per, 6-luc
    {
        if (atribute - atributeFromCharacterClass == 1)
        {
            _minusButtons[atributeId].SetActive(true);
        }
        else if (atribute == atributeFromCharacterClass)
        {
            _minusButtons[atributeId].SetActive(false);
        }
        _freePoints -= delta;
        _freePointsText.text = _freePoints.ToString();
        if (_freePoints == 0)
        {
            for (int i = 0; i < _plusButtons.Count; i++)
            {
                _plusButtons[i].SetActive(false);
            }
        }
        else if (_freePoints > 0)
        {
            for (int i = 0; i < _plusButtons.Count; i++)
            {
                _plusButtons[i].SetActive(true);
            }
        }
    }

    private void SetAtributeValue(TMP_Text atributeText, int atributeValue)
    {
        atributeText.text = atributeValue.ToString();
    }

    private void HideButtons(List<GameObject> _listOfButtons)
    {
        for (int i = 0; i < _listOfButtons.Count; i++)
        {
            _listOfButtons[i].SetActive(false);
        }
    }

    public void OnNextClick()
    {
        ChangeClass(1);
    }

    public void OnPrevClick()
    {
        ChangeClass(-1);
    }

    public void StrPlusPoint()
    {
        _str += 1;
        SetAtributeValue(_classSTR, _str);
        ChangePoints(1, _str, _classesContainer.CharacterClass(_classId).Str, 0);
    }

    public void StrMinusPoint()
    {
        _str -= 1;
        SetAtributeValue(_classSTR, _str);
        ChangePoints(-1, _str, _classesContainer.CharacterClass(_classId).Str, 0);
    }

    public void AgiPlusPoint()
    {
        _agi += 1;
        SetAtributeValue(_classAGI, _agi);
        ChangePoints(1, _agi, _classesContainer.CharacterClass(_classId).Agi, 1);
    }

    public void AgiMinusPoint()
    {
        _agi -= 1;
        SetAtributeValue(_classAGI, _agi);
        ChangePoints(-1, _agi, _classesContainer.CharacterClass(_classId).Agi, 1);
    }

    public void IntPlusPoint()
    {
        _int += 1;
        SetAtributeValue(_classINT, _int);
        ChangePoints(1, _int, _classesContainer.CharacterClass(_classId).Int, 2);
    }

    public void IntMinusPoint()
    {
        _int -= 1;
        SetAtributeValue(_classINT, _int);
        ChangePoints(-1, _int, _classesContainer.CharacterClass(_classId).Int, 2);
    }

    public void EndPlusPoint()
    {
        _end += 1;
        SetAtributeValue(_classEND, _end);
        ChangePoints(1, _end, _classesContainer.CharacterClass(_classId).End, 3);
    }

    public void EndMinusPoint()
    {
        _end -= 1;
        SetAtributeValue(_classEND, _end);
        ChangePoints(-1, _end, _classesContainer.CharacterClass(_classId).End, 3);
    }

    public void WisPlusPoint()
    {
        _wis += 1;
        SetAtributeValue(_classWIS, _wis);
        ChangePoints(1, _wis, _classesContainer.CharacterClass(_classId).Wis, 4);
    }

    public void WisMinusPoint()
    {
        _wis -= 1;
        SetAtributeValue(_classWIS, _wis);
        ChangePoints(-1, _wis, _classesContainer.CharacterClass(_classId).Wis, 4);
    }

    public void PerPlusPoint()
    {
        _per += 1;
        SetAtributeValue(_classPER, _per);
        ChangePoints(1, _per, _classesContainer.CharacterClass(_classId).Per, 5);
    }

    public void PerMinusPoint()
    {
        _per -= 1;
        SetAtributeValue(_classPER, _per);
        ChangePoints(-1, _per, _classesContainer.CharacterClass(_classId).Per, 5);
    }

    public void LucPlusPoint()
    {
        _luc += 1;
        SetAtributeValue(_classLUC, _luc);
        ChangePoints(1, _luc, _classesContainer.CharacterClass(_classId).Luc, 6);
    }

    public void LucMinusPoint()
    {
        _luc -= 1;
        SetAtributeValue(_classLUC, _luc);
        ChangePoints(-1, _luc, _classesContainer.CharacterClass(_classId).Luc, 6);
    }
}