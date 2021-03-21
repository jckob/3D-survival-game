using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStick : MonoBehaviour
{
    public GameObject Player;
    public GameObject CanvasStick;

    private void OnTriggerEnter(Collider other)
    {
        if (Player.tag == "Player")
        {
            CanvasStick.SetActive(true);
        }
    }
}
