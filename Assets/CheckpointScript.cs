﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider c)
    {
        CarController carController = c.GetComponentInParent<CarController>();
        carController.checkpoint();
        carController.LastCheckpoint = transform.position;
    }
}
