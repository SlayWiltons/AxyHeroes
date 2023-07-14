using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats_list", menuName = "Stats list", order = 1)]
public class Stats_Base : ScriptableObject
{
    public int _STR;
    public int _AGI;
    public int _INT;
    public int _END;
    public int _WIS;
    public int _PER;
    public int _LUC;
}
