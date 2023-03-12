using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUP : MonoBehaviour
{
    public float playerlevel;
    public static float exp;

    public Text TextLevel;

    void Update()
    {
        TextLevel.text = playerlevel.ToString();

        if ( exp >= 100)
        {
            playerlevel = 1;
        }

        if (exp >= 300)
        {
            playerlevel = 2;
        }

        if (exp >= 1000)
        {
            playerlevel = 3;
        }

        if (exp >= 3000)
        {
            playerlevel = 4;
        }

        if (exp >= 5000)
        {
            playerlevel = 5;
        }
    }
}
