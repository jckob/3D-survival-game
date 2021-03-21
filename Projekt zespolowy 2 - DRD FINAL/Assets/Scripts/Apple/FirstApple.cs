using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstApple : MonoBehaviour
{
    public GameObject Player;
    public GameObject CanvasApple;

    private void OnTriggerEnter(Collider other)
    {
        if (Player.tag == "Player")
        {
            CanvasApple.SetActive(true);
        }
    }
}
