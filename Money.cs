using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int coins;
    public Text TextCoins;

    void Update()
    {
        TextCoins.text = coins.ToString();
    }
}
