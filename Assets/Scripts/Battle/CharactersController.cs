using System.Collections.Generic;
using UnityEngine;

public class CharactersController : MonoBehaviour
{
    [SerializeField] private List<Character_Template> _characters;

    private void Start()
    {
        for (int i = 0; i < _characters.Count; i++)
        {
            _characters[i].SetSTR(Random.Range(1, 10));
        }

        for (int i = 0; i < _characters.Count; i++)
        {
            Debug.Log(_characters[i].GetSTR());
        }
    }
}
