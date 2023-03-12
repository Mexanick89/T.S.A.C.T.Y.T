using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPlayer : MonoBehaviour
{
    [SerializeField] AudioSource damagers;
    [SerializeField] AudioSource PickUppower;
    public GameObject damagecran;
    public GameObject powerpower;
    public GameObject endgamess;
    public Animator animatorP;

    private void Start()
    {
        animatorP = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Claw")
            {
            animatorP.SetBool("Damage", true);
            damagers.Play();
            PowerPlayer.health -= 5;
            damagecran.SetActive(true);
            Invoke("DamageOff", 0.7f);
            Invoke("DamageOff2", 0.2f);

            }

        if (other.gameObject.tag == "power")
            {
            PickUppower.Play();
            PowerPlayer.health += 25;
        }

        if (other.gameObject.tag == "endgame")
        {
            endgamess.SetActive(true);
            Time.timeScale = 0;
            Money.coins += 500;
        }
    }

    private void DamageOff()
    {
        damagecran.SetActive(false);
    }

    private void DamageOff2()
    {
        animatorP.SetBool("Damage", false);
    }
}
