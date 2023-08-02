using System.Collections.Generic;
using UnityEngine;

public class Classes_Container : MonoBehaviour
{
    [SerializeField] private List<Char_Class> _characterClasses;

    public Char_Class CharacterClass(int i)
    {
        return _characterClasses[i];
    }

    public int ClassesCount()
    {
        return _characterClasses.Count;
    }

}
