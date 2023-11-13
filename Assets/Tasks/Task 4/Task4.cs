using System;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        Transform shelfInstance = Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя;
        DestroyImmediate(shelfInstance.gameObject);
    }
    
}
