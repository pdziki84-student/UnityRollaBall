﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);   
    }
}
