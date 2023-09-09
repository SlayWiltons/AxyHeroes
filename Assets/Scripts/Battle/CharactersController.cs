using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersController : MonoBehaviour
{
    [SerializeField] private Character_Template _characterTemplateForTest;
    [SerializeField] private List<Character_Template> _characters;
    private Character_Template charactur;

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            //_characters.Add(charactur = new Character_Template());
            _characters.Add(charactur = ScriptableObject.CreateInstance<Character_Template>());
        }
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
