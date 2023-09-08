using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalModule : MenuModule
{
    [SerializeField] private PortretGenderNameModule _modulePortret;
    [SerializeField] private ClassStatsModule _moduleClass;

    [SerializeField] private TMP_Text _name;

    [SerializeField] private TMP_Text _className;

    [SerializeField] private Image _portret;

    [SerializeField] private TMP_Text _classSTR;
    [SerializeField] private TMP_Text _classAGI;
    [SerializeField] private TMP_Text _classINT;
    [SerializeField] private TMP_Text _classEND;
    [SerializeField] private TMP_Text _classWIS;
    [SerializeField] private TMP_Text _classPER;
    [SerializeField] private TMP_Text _classLUC;

    private void OnEnable()
    {
        GetCharacterData();
    }

    private void GetCharacterData()
    {
        _name.text = _modulePortret.Name();
        _portret.sprite = _modulePortret.Portet();
        _className.text = _moduleClass.Class();
        _classSTR.text = _moduleClass.Str().ToString();
        _classAGI.text = _moduleClass.Agi().ToString();
        _classINT.text = _moduleClass.Int().ToString();
        _classEND.text = _moduleClass.End().ToString();
        _classWIS.text = _moduleClass.Wis().ToString();
        _classPER.text = _moduleClass.Per().ToString();
        _classLUC.text = _moduleClass.Luc().ToString();
    }
}
