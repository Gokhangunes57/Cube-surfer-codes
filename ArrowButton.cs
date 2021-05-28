using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : MonoBehaviour
{
    public GameObject arrowButton;
    private GameObject player;
    private Collectibles cubecount;
 
    private NextlevelController next;
   
    private void Start()
    {
      
        player = GameObject.FindWithTag("Player");
        cubecount = FindObjectOfType<Collectibles>();
        next = FindObjectOfType<NextlevelController>();
    }

    public void ArrowButtonClicked()
    {
        arrowButton.SetActive(false);
    }
    
    void Update()
    {
        
      GameProcess();


      

    }

    private void GameProcess()
    {

        int sayi = cubecount.CubePrefabInstantiate.Count;
        if ((arrowButton.activeInHierarchy == false && player.transform.position.z <60) )
        {
            player.transform.position += Vector3.forward * 23*Time.deltaTime;
        }
        if ((arrowButton.activeInHierarchy == false && player.transform.position.z >=60&&sayi>1) )
        {
            player.transform.position += Vector3.forward * 34*Time.deltaTime;
           
        }
       

        if (arrowButton.activeInHierarchy == false && sayi==1&& player.transform.position.z>100)
        {
            next.Nextlevelpanel.SetActive(true);
        }
    }
   
}
