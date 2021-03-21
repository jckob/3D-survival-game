using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("PickUpSound");
        WoodScore.theScore += 1;
        Destroy(gameObject);

    }
}
