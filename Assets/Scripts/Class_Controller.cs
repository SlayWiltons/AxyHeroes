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

    private void Start()
    {
        if (isClassesExist())
        {
            _classId = 0;
            SetClassName();
            SetAllAtributes();
        }

        _freePoints = _freePointBase;
        _freePointsText.text = _freePoints.ToString();
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

    public void OnPrevClick()
    {
        ChangeClass(-1);
    }

    public void OnNextClick()
    {
        ChangeClass(1);
    }

    private void SetAtributeValue(TMP_Text atributeText, int atributeValue)
    {
        atributeText.text = atributeValue.ToString();
    }
}
