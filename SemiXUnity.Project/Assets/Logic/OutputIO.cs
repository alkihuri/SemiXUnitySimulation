using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputIO : IOEntity
{

     
    private void OnTriggerStay(Collider other)
    {
        GameObject enteredOne = other.gameObject;
        if (enteredOne.GetComponent<IOEntity>())
        {
            enteredOne.GetComponent<IOEntity>().SetState(_currentState);
        }
    }

    internal void SetState(bool state)
    {
        base.SetState(state);
    }
}
