using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopTree : MonoBehaviour
{
    public GameObject PickAxe;
    int i = 3;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0) && PickAxe.tag == "PickAxe")
        {
            if (i >= 1)
            {
                FindObjectOfType<AudioManager>().Play("ChopSoundTree");
                i -= 1;
            }
        }
    }
    private void Update()
    {
        if (i <= 0)
        {
            FindObjectOfType<AudioManager>().Play("BreakSoundTree");
            Destroy(gameObject);
        }
    }


}
