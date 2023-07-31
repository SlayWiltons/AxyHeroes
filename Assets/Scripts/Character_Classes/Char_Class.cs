using UnityEngine;

[CreateAssetMenu(fileName = "Class", menuName = "Character's class", order = 2)]
public class Char_Class: ScriptableObject
{
    public string Name;
    public int Str;
    public int Agi;
    public int Int;
    public int End;
    public int Wis;
    public int Per;
    public int Luc;
}
