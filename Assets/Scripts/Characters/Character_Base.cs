using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Character_Base", menuName = "Character Base", order = 2)]
public class Character_Base : ScriptableObject
{
    public string Name;
    public RawImage Avatar;
    [SerializeField] private bool isCharacter; 

    public enum Alignment
    {
        Good,
        Neutral,
        Evil
    }

    public Alignment CharAlignment;
}
