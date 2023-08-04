using TMPro;
using UnityEngine;

public class Stats_Controller : MonoBehaviour
{
    [SerializeField] private Classes_Container _classesContainer;
    [SerializeField] private TMP_Text _className;
    [SerializeField] private TMP_Text _classSTR;
    [SerializeField] private TMP_Text _classAGI;
    [SerializeField] private TMP_Text _classINT;
    [SerializeField] private TMP_Text _classEND;
    [SerializeField] private TMP_Text _classWIS;
    [SerializeField] private TMP_Text _classPER;
    [SerializeField] private TMP_Text _classLUC;
    [SerializeField] private TMP_Text _freePoints;
    [SerializeField] private int _freeAttributesPoints;
    private int _classesCount;

    private void Start()
    {
        _classesCount = _classesContainer.ClassesCount();
        SetClassParams(0);
        Debug.Log(_classesCount);
    }

    private void SetClassParams(int i)
    {
        if (_classesCount != 0)
        {
            _className.text = _classesContainer.CharacterClass(i).Name;
            _classSTR.text = _classesContainer.CharacterClass(i).Str.ToString();
            _classAGI.text = _classesContainer.CharacterClass(i).Agi.ToString();
            _classINT.text = _classesContainer.CharacterClass(i).Int.ToString();
            _classEND.text = _classesContainer.CharacterClass(i).End.ToString();
            _classWIS.text = _classesContainer.CharacterClass(i).Wis.ToString();
            _classPER.text = _classesContainer.CharacterClass(i).Per.ToString();
            _classLUC.text = _classesContainer.CharacterClass(i).Luc.ToString();
        }
        else return;
    }

}
