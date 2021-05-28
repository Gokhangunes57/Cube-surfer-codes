using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CollectDiamond : MonoBehaviour
{
    public GameObject Diamondprefab;
    public GameObject Panel;
    public Text skortxt;
    public int puan = 0;
    
  
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="elmas")
        {
            puan++;
            skortxt.text = puan.ToString();
            
            
            Destroy(other.gameObject);
            Instantiate(Diamondprefab, Camera.main.WorldToScreenPoint(transform.position), Panel.transform.rotation,
                Panel.transform);
        }

    }

   
}
