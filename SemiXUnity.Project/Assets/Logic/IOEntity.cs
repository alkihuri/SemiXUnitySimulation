using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOEntity : MonoBehaviour
{
    [SerializeField] public  bool _currentState;  
    public virtual void SetState(bool state)
    {
        if (_currentState != state)
            _currentState = state; 
    }

    private void OnTriggerExit(Collider other)
    {
        ChainInterupt();
    }

    private void ChainInterupt()
    {
        _currentState = false;
    }
}
