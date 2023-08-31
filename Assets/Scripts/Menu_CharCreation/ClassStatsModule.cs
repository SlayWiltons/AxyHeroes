using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClassStatsModule : MenuModule
{
    [SerializeField] private Classes_Container _classesContainer;

    [SerializeField] private TMP_Text _freePointsText;
    [SerializeField] private TMP_Text _className;

    [SerializeField] private TMP_Text _classSTR;
    [SerializeField] private TMP_Text _classAGI;
    [SerializeField] private TMP_Text _classINT;
    [SerializeField] private TMP_Text _classEND;
    [SerializeField] private TMP_Text _classWIS;
    [SerializeField] private TMP_Text _classPER;
    [SerializeField] private TMP_Text _classLUC;

    [SerializeField] private List<GameObject> _plusButtons;
    [SerializeField] private List<GameObject> _minusButtons;
}
