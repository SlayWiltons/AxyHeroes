using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats_list", menuName = "Stats list", order = 1)]
public class Stats_Base : ScriptableObject
{
    [SerializeField] private int _STR;
    [SerializeField] private int _AGI;
    [SerializeField] private int _INT;
    [SerializeField] private int _END;
    [SerializeField] private int _WIS;
    [SerializeField] private int _PER;
    [SerializeField] private int _LUC;
}
