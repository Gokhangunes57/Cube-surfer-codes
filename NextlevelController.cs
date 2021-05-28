using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextlevelController : MonoBehaviour
{
    public GameObject Nextlevelpanel;
    public Text paneldiamond;
    private CollectDiamond diamondNumber;
    void Start()
    {
        Nextlevelpanel.SetActive(false);
        diamondNumber = FindObjectOfType<CollectDiamond>();
    }

    // Update is called once per frame
    void Update()
    {
        paneldiamond.text = diamondNumber.puan.ToString();
    }

    public void NextlevelButton()
    {

        SceneManager.LoadScene("Scenes/SampleScene");

    }
}
