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
    private string _name;
    private int _classesCount;
    private int _freeAttribPoints;
    private int _str;
    private int _agi;
    private int _int;
    private int _end;
    private int _wis;
    private int _per;
    private int _luck;


    private void Start()
    {
        _classesCount = _classesContainer.ClassesCount();
        _freeAttribPoints = _freeAttributesPoints;
        if (_classesCount != 0)
        {
            GetClassParams(0);
            SetClassParams();
        }
        else return;
    }

    

    private void GetClassParams(int i)
    {
        _name = _classesContainer.CharacterClass(i).name;
        _str = _classesContainer.CharacterClass(i).Str;
        _agi = _classesContainer.CharacterClass(i).Agi;
        _int = _classesContainer.CharacterClass(i).Int;
        _end = _classesContainer.CharacterClass(i).End;
        _wis = _classesContainer.CharacterClass(i).Wis;
        _per = _classesContainer.CharacterClass(i).Per;
        _luck = _classesContainer.CharacterClass(i).Luc;
    }

    private void SetClassParams()
    {
        _className.text = _name;
        _classSTR.text = _str.ToString();
        _classAGI.text = _agi.ToString();
        _classINT.text = _int.ToString();
        _classEND.text = _end.ToString();
        _classWIS.text = _wis.ToString();
        _classPER.text = _per.ToString();
        _classLUC.text = _luck.ToString();
    }

    public void AddPoints(TMP_Text attribute)
    {
        if (_freeAttribPoints > 0)
        {
            _freeAttribPoints -= 1;
        }
    }
}
