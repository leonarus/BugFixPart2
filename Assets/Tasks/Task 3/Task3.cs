using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Awake()
    {
        _wallPrefab.isKinematic = false;
        Instantiate(_wallPrefab);
    }
}
