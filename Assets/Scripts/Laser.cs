﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speedLaser = 8;
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up *_speedLaser*Time.deltaTime);
        if (transform.position.y > 7)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
         
                Destroy(gameObject);
            
        }
    }

}
