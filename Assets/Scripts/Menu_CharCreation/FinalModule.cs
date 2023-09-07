using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalModule : MenuModule
{
    [SerializeField] private MenuModule _modulePortret;
    [SerializeField] private MenuModule _moduleClass;

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
}
