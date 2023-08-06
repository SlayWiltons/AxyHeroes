using TMPro;
using UnityEngine;

public class Class_Controller : MonoBehaviour
{
    [SerializeField] private Classes_Container _classesContainer;
    [SerializeField] private TMP_Text _className;

    private int _classesCount;
    private int _classId;

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
            SetClassName(0);
        }
    }

    private void SetClassName(int i)
    {
        _classId = i;
        _className.text = _classesContainer.CharacterClass(i).Name;
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
        SetClassName(_classId);
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
