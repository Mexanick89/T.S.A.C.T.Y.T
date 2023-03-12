using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroolEnemy : MonoBehaviour
{
    public float seeDistance = 10f;
    public float attackDistance = 2f;
    public float speed;
    private Transform target;
    private Animator animatoren;

    private void Start()
    {
        target = GameObject.FindWithTag ("Player").transform;
        animatoren = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Vector3.Distance (transform.position, target.transform.position) < seeDistance)
        {
            animatoren.SetBool("RunEnemy", true);
            if (Vector3.Distance (transform.position, target.transform.position) > attackDistance)
            {
                transform.LookAt(target.transform);
                transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));

            }
        }
        else
        {

        }
    }
}
