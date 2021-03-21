using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectApple : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            AppleCollect.theScore += 1;
            Destroy(gameObject);
        
    }
}
