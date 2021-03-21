using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatApple : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        AppleCollect.theScore -= 1;

    }
}
