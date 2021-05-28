using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Collectibles : MonoBehaviour
{


    public GameObject cubePrefab;
    private Transform Player;
    private Vector3 PlayerPosition;
    private Vector3 PlayerPositionY;
    private GameObject InstantiateObjects;
    public GameObject PlayerActive;
    public List<GameObject> CubePrefabInstantiate;
    private GameObject CubeParent;
    private Vector3 lastcubes;
    private GameObject karakter;
    private Vector3 karakterposition;
    private Animator anim;
    private bool plusanimation = false;
    private Plus plusscript;
    private int[] imagerandom = new[] {-200, -150, -100, -50, 0, 50, 100, 150, 200, 250};

   


    IEnumerator Bekleme()
    {

        yield return new WaitForSeconds(0.3f);
        plusscript.image.enabled = false;
    }




        private void Start()
        {
            Player = GameObject.FindWithTag("Player").GetComponent<Transform>();
            CubePrefabInstantiate = new List<GameObject>();
            CubeParent =GameObject.Find("CubeParent");
            karakter = GameObject.FindWithTag("karakter");
            karakterposition = new Vector3(karakter.transform.position.x,karakter.transform.position.y,karakter.transform.position.z);
            anim = GameObject.FindWithTag("karakter").GetComponent<Animator>();
            
            PlayerPosition = new Vector3(Player.transform.position.x, Player.transform.position.y,
                Player.transform.position.z);
            PlayerPositionY = new Vector3(0, 0, 0);
            lastcubes = new Vector3(0, 3, 0);
            plusscript = FindObjectOfType<Plus>();



        }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectible")
        {
          InstantiateObjects =  Instantiate(cubePrefab,transform.position+PlayerPositionY , Quaternion.identity);
          InstantiateObjects.transform.SetParent(Player);
          CubePrefabInstantiate.Add(InstantiateObjects);
          PlayerPositionY.y += 3;
          if (CubePrefabInstantiate.Count>1)
          {
              karakter.transform.position += lastcubes;
          }

          if (plusanimation==false)
          {
              plusanimation = true;
              if (plusanimation==true)
              {
                  plusscript.image.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,imagerandom[Random.Range(0,10) ]);
                  plusscript.PlusAnimation();
                  plusanimation = false;
                  StartCoroutine(Bekleme());
                  

              }

          }
          
          

          
          
          anim.SetTrigger("jump");
          Destroy(other.gameObject);
          
          
          

        }
        if ( other.gameObject.tag=="obstacle")
        {
            for (int i = 0; i < 2; i++)
            {
                Instantiate(cubePrefab,CubePrefabInstantiate[i].transform.position, Quaternion.identity);
            }

            karakter.transform.position = karakter.transform.position - new Vector3(0, 3, 0);


        }
        if ( other.gameObject.tag=="obstacle2")
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(cubePrefab,CubePrefabInstantiate[i].transform.position, Quaternion.identity);
            }
            karakter.transform.position = karakter.transform.position - new Vector3(0, 3, 0);
        }
        if ( other.gameObject.tag=="obstacle3")
        {
            for (int i = 0; i <3; i++)
            {
                Instantiate(cubePrefab,CubePrefabInstantiate[i].transform.position, Quaternion.identity);
            }
            karakter.transform.position = karakter.transform.position - new Vector3(0, 3, 0);
        }
        if ( other.gameObject.tag=="obstacle4")
        {
            for (int i = 0; i < 2; i++)
            {
                Instantiate(cubePrefab,CubePrefabInstantiate[i].transform.position, Quaternion.identity);
            }
            karakter.transform.position = karakter.transform.position - new Vector3(0, 3, 0);
        }

        if (other.gameObject.tag=="cube1")
        {
            Instantiate(cubePrefab,transform.position, Quaternion.identity);
            int sayi = CubePrefabInstantiate.Count;
            
           
            
        }
        if (other.gameObject.tag=="cube2")
        {
            Instantiate(cubePrefab,transform.position+lastcubes, Quaternion.identity);
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[0]);
            CubePrefabInstantiate.RemoveAt(0);
           
            
        }
        if (other.gameObject.tag=="cube3")
        {
            Instantiate(cubePrefab,transform.position+(2*lastcubes), Quaternion.identity);  
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[0]);
            CubePrefabInstantiate.RemoveAt(0);
        }
        if (other.gameObject.tag=="cube4")
        {
            Instantiate(cubePrefab,transform.position+(3*lastcubes), Quaternion.identity);
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[0]);
            CubePrefabInstantiate.RemoveAt(0);
           
        }
        if (other.gameObject.tag=="cube5")
        {
            Instantiate(cubePrefab,transform.position+(4*lastcubes), Quaternion.identity);
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[0]);
            CubePrefabInstantiate.RemoveAt(0);
           
        }
        if (other.gameObject.tag=="cube6")
        {
                    Instantiate(cubePrefab,transform.position+(5*lastcubes), Quaternion.identity);
                    int sayi = CubePrefabInstantiate.Count;
                    Destroy(CubePrefabInstantiate[0]);
                    CubePrefabInstantiate.RemoveAt(0);
                   
        }




        
        

        
       

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="obstacle")
        {
           PlayerActive.SetActive(false);
        }
        else
        {
            PlayerActive.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="obstacle")
        {
            int sayi = CubePrefabInstantiate.Count;
          Destroy(CubePrefabInstantiate[sayi-1]);
          CubePrefabInstantiate.RemoveAt(sayi-1);
          PlayerPositionY.y -= 3;
         
        }
        if (other.gameObject.tag=="obstacle2")
        {
           
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[sayi-1]);
            CubePrefabInstantiate.RemoveAt(sayi-1);
            PlayerPositionY.y -= 3;
           
        }
        if (other.gameObject.tag=="obstacle3")
        {
            
            
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[sayi-1]);
            CubePrefabInstantiate.RemoveAt(sayi-1);
            PlayerPositionY.y -= 3;
        
        }
        if (other.gameObject.tag=="obstacle4")
        {
          
            int sayi = CubePrefabInstantiate.Count;
            Destroy(CubePrefabInstantiate[sayi-1]);
            CubePrefabInstantiate.RemoveAt(sayi-1);
            PlayerPositionY.y -= 3;
           
        }
    }
}
