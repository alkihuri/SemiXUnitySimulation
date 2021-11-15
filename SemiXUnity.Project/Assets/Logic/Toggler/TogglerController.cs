using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TogglerController : MonoBehaviour
{
    [SerializeField] Transform _isOnTrans;
    [SerializeField] Transform _isOffTrans;
    [SerializeField] GameObject _shapeOfToggler;
    [SerializeField] bool _toggleState ;
    OutputIO _toggleOutput;
    UnityEvent toggleStateChange;
    [SerializeField] Material isOnMaterial; 
    [SerializeField] Material isOffMaterial;
    void Start()
    {
        _toggleOutput = GetComponentInChildren<OutputIO>();
        if (toggleStateChange == null)
            toggleStateChange = new UnityEvent();
        toggleStateChange.AddListener(ChangeState);
        toggleStateChange.AddListener(ChangeShapePos);
        toggleStateChange.AddListener(ChangeColor);
    }
    private void Awake()
    {
        ChangeColor();
        ChangeShapePos();
    }
    private void OnMouseUp()
    {
        _toggleState = !_toggleState;
        toggleStateChange.Invoke();
    }

    private void ChangeState()
    {
        _toggleOutput.SetState(_toggleState);
    }

    private void ChangeShapePos()
    {
        if (_toggleState)
            _shapeOfToggler.transform.position = _isOnTrans.position;
        else
            _shapeOfToggler.transform.position = _isOffTrans.position;
    }
    private void ChangeColor()
    {
        if (_toggleState)
            _shapeOfToggler.GetComponent<Renderer>().material = isOnMaterial;
        else
            _shapeOfToggler.GetComponent<Renderer>().material = isOffMaterial;
    }
}
