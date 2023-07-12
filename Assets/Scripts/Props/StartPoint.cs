using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;

    void Start()
    {
        Instantiate(_playerPrefab, transform);
    }
}
