using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    
    public Slider slider;
    private Transform playermove;
    
    void Start()
    {
        playermove = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    private void Update()
    {
        slider.value = playermove.transform.position.z + 301;
    }

   
}
