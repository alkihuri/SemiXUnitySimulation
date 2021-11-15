using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutpuIORepiter : OutputIO
{ 
    [SerializeField] InputIO _inputIO_FirstPin;

    [SerializeField] InputIO _inputIO_SecondPin;

    private void Update()
    {
        SetState(_inputIO_FirstPin._currentState || _inputIO_SecondPin._currentState);
    }
}
