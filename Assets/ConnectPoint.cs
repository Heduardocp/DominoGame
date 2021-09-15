using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectPoint : MonoBehaviour, IConnectPoint
{
    [SerializeField]
    private Transform _gameObject;

    public Vector3 position {
        get => _gameObject.position;
    }
    public Quaternion rotation {
        get => _gameObject.rotation;
    }
    private void Awake() {
        _gameObject = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
