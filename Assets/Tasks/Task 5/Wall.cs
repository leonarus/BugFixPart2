using System;
using UnityEngine;

/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Start()
    {
        _detector = FindObjectOfType<Detector>();
        if (_detector!= null)
        {
            _detector.CoinDetected += OnCoinDetected;
        }
    }

    private void OnDestroy()
    {
        if (_detector != null)
        {
            _detector.CoinDetected -= OnCoinDetected;
        }
    }

    private void OnCoinDetected()
    {
        ChangePosition();
    }
    
    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
}