using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DiamondUi : MonoBehaviour
{
    private Transform panel;
    private Sequence elmasanimation;
    
    void Start()
    {
        Animationhazirla();
    }

    public void Animationhazirla()
    {

        panel = GameObject.FindGameObjectWithTag("fakeimage").transform;
        elmasanimation = DOTween.Sequence();

        elmasanimation.Append(transform.DOMove(panel.position, 1)).SetEase(Ease.OutSine);
        


    }
}
