﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd100 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col_obj)
    {
        Score.AddPoint(100);
    }
}
