using TMPro;
using UnityEngine;

public class Class_Controller : MonoBehaviour
{
    [SerializeField] private Classes_Container _classesContainer;
    [SerializeField] private TMP_Text _freePointsText;
    [SerializeField] private TMP_Text _className;
    [SerializeField] private int _freePointBase;

    private int _classesCount;
    private int _classId;
    private int _freePoints;

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
        }

        _freePoints = _freePointBase;
        _freePointsText.text = _freePoints.ToString();
    }

    private void SetClassName()
    {
        _className.text = _classesContainer.CharacterClass(_classId).Name;
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
    }

    public void OnPrevClick()
    {
        ChangeClass(-1);
    }

    public void OnNextClick()
    {
        ChangeClass(1);
    }
}
