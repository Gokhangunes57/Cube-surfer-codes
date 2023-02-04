using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class elmas : MonoBehaviour
{
    public GameObject elmasprefab;
    private Vector3 positionelmas;
    private Quaternion aci;

    private void Start()
    {

        aci =Quaternion.Euler(-90,0,0);
        for (int i = 0; i < 14; i++)
        {
            positionelmas = new Vector3(Random.Range(-7f,7f),52,Random.Range(-273f,96f));
            Instantiate(elmasprefab, positionelmas, aci);
        }





    }
}
