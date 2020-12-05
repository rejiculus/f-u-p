﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _targetObject;

    private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _targetObject.position + _offset;
    }
}
