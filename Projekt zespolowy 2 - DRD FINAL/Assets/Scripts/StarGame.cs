using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarGame : MonoBehaviour
{
    public PlayerMovementScript movement;
    public MouseLook kamera;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject mainCanvas;
    public int i = 0;
    public bool scena1 = false;
    public GameObject Manager;
    public GameObject Manager2;
    public GameObject Manager3;
   
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("introo");
        canvas1.SetActive(true);
        canvas2.SetActive(false);
        movement.enabled = false;
        kamera.enabled = false;
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (i == 0)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                scena1 = true;
                i += 1;
            }
            else
            {
                if (scena1 && Input.GetKeyDown(KeyCode.Space))
                {
                    canvas2.SetActive(false);
                    movement.enabled = true;
                    kamera.enabled = true;
                    mainCanvas.SetActive(true);
                    Manager.SetActive(false);
                    Manager2.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Animal");
                    Manager3.SetActive(true);



                }
            }
        }
    }
}
