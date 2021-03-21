using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject Inv;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.I))
        {
            Inv.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Inv.SetActive(false);
        }

    }
}
