using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Character", menuName = "New character", order = 1)]
public class Character_Base : ScriptableObject
{
    [SerializeField] private int _STR;
    [SerializeField] private int _AGI;
    [SerializeField] private int _INT;
    [SerializeField] private int _END;
    [SerializeField] private int _WIS;
    [SerializeField] private int _PER;
    [SerializeField] private int _LUC;
}
