using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSprey : MonoBehaviour
{
    private ParticleSystem spreyler;
    private bool is_open;
   
    void Start()
    {
        spreyler = GameObject.FindWithTag("sprey").GetComponent<ParticleSystem>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (is_open)
        {
            spreyler.Play();
        }
        
        
    }


    
}
