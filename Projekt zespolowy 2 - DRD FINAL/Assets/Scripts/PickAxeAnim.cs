using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxeAnim : MonoBehaviour
{
    public GameObject PickAxe;
    public GameObject PickAxe1;
    public GameObject FlashLight;
    public GameObject Axe;


    public void Update()
    {
        if (Input.GetButtonDown("PickAxe"))
        {
            FlashLight.SetActive(false);
            Axe.SetActive(false);
            PickAxe.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("git");
            Axe.GetComponent<Animator>().Play("AxeAnim");
        }
    }
}
