using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PagesScript : MonoBehaviour
{
    public GameObject Book1;
    public GameObject Book2;
    public GameObject Book3;
    public GameObject Book4;
    public GameObject Book5;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;
    public GameObject Canvas5;
    bool night1 = true;
    public LightingManager lightingManager;
    public Collliderbook1 check1;
    public ColliderBook2 check2;
    public ColliderBook3 check3;
    public ColliderBook4 check4;
    public ColliderBook5 check5;
    bool newday = false;
    int time = 0;


    void Start()
    {

    }


    void Update()
    {
        if (lightingManager.TimeofDay > 180f && newday)
        {

            newday = false;
            time += 1;
            Debug.Log(time);

        }
        if (lightingManager.TimeofDay > 50f && lightingManager.TimeofDay < 60f)
        {
            newday = true;
        }


        if ((lightingManager.TimeofDay >= 180f || lightingManager.TimeofDay <= 60f) && night1)
        {

            Book1.SetActive(true);
            if (check1.check1)
            {
                Book1.SetActive(false);
                time = 1;

            }



        }
        if (lightingManager.TimeofDay <= 180f && lightingManager.TimeofDay >= 60f)
        {
            Book1.SetActive(false);
            Book2.SetActive(false);
        }
        if ((lightingManager.TimeofDay >= 180f || lightingManager.TimeofDay <= 60f) && check1.check1 && time == 1)
        {
            Book2.SetActive(true);

            if (time == 1 && check2.check2 == false)
            {
                time = 1;
            }
            else
            {
                Book2.SetActive(false);
                time = 2;
            }


        }
        if ((lightingManager.TimeofDay >= 180f || lightingManager.TimeofDay <= 60f) && check2.check2 && time == 2)
        {
            Book3.SetActive(true);

            if (time == 2 && check3.check3 == false)
            {
                time = 2;
            }
            else
            {
                Book3.SetActive(false);
                time = 3;
            }


        }
        if ((lightingManager.TimeofDay >= 180f || lightingManager.TimeofDay <= 60f) && check3.check3 && time == 3)
        {
            Book4.SetActive(true);

            if (time == 3 && check4.check4 == false)
            {
                time = 3;
            }
            else
            {
                Book4.SetActive(false);
                time = 4;
            }


        }
        if ((lightingManager.TimeofDay >= 180f || lightingManager.TimeofDay <= 60f) && check4.check4 && time == 4)
        {
            Book5.SetActive(true);

            if (time == 4 && check5.check5 == false)
            {
                time = 4;
            }
            else
            {

                Book5.SetActive(false);
                time = 5;
            }


        }







    }

}

