﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneScore : MonoBehaviour
{
    public Text scoreText;
    public static int theScore;

    void Update()
    {
        scoreText.text = theScore.ToString();
    }
}
