using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{
    public Image image;
    public Animator anim;
    public float interval = 0.5f;
    public float nextinterval = 0;
    void Start()
    {
        image.enabled = false;
        


    }

    public void PlusAnimation()
    {
        image.enabled = true;
        anim.SetTrigger("plus");
        

    }

    
    
    
}
