using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("PickUpSound");
        StoneScore.theScore += 1;
        Destroy(gameObject);

    }
}
