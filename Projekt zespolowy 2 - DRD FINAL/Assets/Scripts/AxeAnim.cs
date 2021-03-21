using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAnim : MonoBehaviour
{
    public GameObject Axe;
    public GameObject Axe1;
    public GameObject FlashLight;
    public GameObject PickAxe;
    

   public void Update()
   {
        if(Input.GetButtonDown("Axe"))
        {
            FlashLight.SetActive(false);
            PickAxe.SetActive(false);
            Axe1.SetActive(true);
        }
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("git");
            Axe.GetComponent<Animator>().Play("AxeAnim");
        }
   }
}
