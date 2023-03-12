using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01 : MonoBehaviour
{
    [SerializeField] AudioSource RunSound;

    public int HP;
    public int MaxHP = 100;
    public int MinHP = 0;

    private Animator animatoren2;

    void Start()
    {
        animatoren2 = GetComponent<Animator>();
        HP = MaxHP;
    }
    void FixedUpdate()
    {
        if(HP <= 0)
        {
            animatoren2.SetBool("DeathEnemy", true);
            Invoke("DeathEnemy", 3f);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "mainbullet")
        {
            HP -= 25;
        }

        if (other.gameObject.tag == "PPlayer")
        {
            AttackMonstro();
        }
    }
    private void DeathEnemy()
    {
        LevelUP.exp += 25;
        Destroy(gameObject);
    }

    private void AttackMonstro()
    {
        animatoren2.SetBool("AttackEnemy", true);
        RunSound.Play();
    }
}
