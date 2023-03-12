using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerPlayer : MonoBehaviour
{
    Image healthBar;
    public static float health = 100;
    public float MaxHealth = 100;
    public GameObject gameover;

    public GameObject jo;
    public GameObject shoo;
    public GameObject hpshka;

    void Start()
    {
        health = MaxHealth;
        healthBar = GetComponent<Image>();
    }

    void FixedUpdate()
    {
        healthBar.fillAmount = health/MaxHealth;

        if (health <= 0)
        {
            shoo.SetActive(false);
            jo.SetActive(false);
            hpshka.SetActive(false);
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
