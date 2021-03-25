using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAgentAi : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;
    [SerializeField] private float _rotSpeed = 3f;

    [SerializeField] private bool _isWandering =  false;
    [SerializeField] private bool _isRotatingLeft =  false;
    [SerializeField] private bool _isRotatingRight =  false;
    [SerializeField] private bool _isWalking =  false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
