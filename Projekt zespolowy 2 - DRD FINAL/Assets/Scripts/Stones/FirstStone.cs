using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStone : MonoBehaviour
{
    public GameObject Player;
    public GameObject CanvasStone;

    private void OnTriggerEnter(Collider other)
    {
        if (Player.tag == "Player")
        {
            CanvasStone.SetActive(true);
        }
    }
}
