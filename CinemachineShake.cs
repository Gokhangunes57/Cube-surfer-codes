﻿using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CinemachineShake : MonoBehaviour
{
    public Transform target;
    public Vector3 target_Offset;
    private void Start()
    {
        target_Offset = transform.position - target.position;
    }
    void Update()
    {
        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 0.1f);
        }
    }
}
