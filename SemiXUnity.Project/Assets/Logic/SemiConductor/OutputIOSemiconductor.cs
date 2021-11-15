using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputIOSemiconductor : OutputIO
{
    [SerializeField] MainIOSemiconductor _mainIO;
    [SerializeField] InputIO _inputIO;

    private void Update()
    {
        SetState(_mainIO._currentState && _inputIO._currentState);
    }
}
