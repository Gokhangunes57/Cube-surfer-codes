using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiController : MonoBehaviour
{
    private ParticleSystem confeti1;
    private ParticleSystem confeti2;
    private ParticleSystem confeti3;
    void Start()
    {
        confeti1 = GameObject.Find("confetione").GetComponent<ParticleSystem>();
        confeti2 = GameObject.Find("confetitwo").GetComponent<ParticleSystem>();
        confeti3 = GameObject.Find("confetithree").GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            confeti1.Play();
            confeti2.Play();
            confeti3.Play();
        }
    }
}
