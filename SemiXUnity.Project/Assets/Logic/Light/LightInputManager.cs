using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInputManager : MonoBehaviour
{
    [SerializeField] Light _light;
    [SerializeField] InputIO _inputIO;
    // Update is called once per frame
    void Update()
    {
        _light.enabled =  _inputIO._currentState ;
    }
   
}
