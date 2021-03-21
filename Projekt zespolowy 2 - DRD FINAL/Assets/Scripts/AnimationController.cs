using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject Player2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {

            Player2.GetComponent<Animator>().Play("FlashLight");

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Player2.GetComponent<Animator>().Play("FlashOfff");
        }

    }
}

