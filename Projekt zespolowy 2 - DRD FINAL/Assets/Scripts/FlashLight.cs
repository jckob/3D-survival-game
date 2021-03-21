using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject Light;
    public LightingManager lightingManager;
    public GameObject Flash;
    public GameObject FLOFF;
    public Transform Player;
    public Transform FL;
    public float mouseSensitivity = 100f;
    public GameObject Player2;
    public Animator anim;
    bool good;
    public GameObject Axe;
    public GameObject PickAxe;
  
    public void Start()
    {
        anim = GetComponent<Animator>();
        Light = GameObject.FindWithTag("DayAndNight");
        if (Light != null)
        {
           lightingManager = lightingManager.GetComponent<LightingManager>();
        }
       
        
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.E) )
        {
            Axe.SetActive(false);
            PickAxe.SetActive(false);
            FLOFF.SetActive(true);
            Flash.SetActive(true);
            Player2.GetComponent<Animator>().Play("FlashLight");
            

        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Player2.GetComponent<Animator>().Play("flashOfff");
            Flash.SetActive(false);
            //FLOFF.SetActive(false);

        }
    }
    
    

}
