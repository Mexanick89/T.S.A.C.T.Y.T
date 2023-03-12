using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] AudioSource shagi;

    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        dirX = joystick.Horizontal * speed;
        dirY = joystick.Vertical * speed;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        transform.rotation = Quaternion.LookRotation(rb.velocity);

        if (joystick.Horizontal >= 0.001 || joystick.Vertical >= 0.001)
        {
            animator.SetBool("Go", true);
        }
        else
        {
            shagi.Play();
            animator.SetBool("Go", false);      
        }

        if (joystick.Horizontal <= -0.001 || joystick.Vertical <= -0.001)
        {
            animator.SetBool("Go", true);
        }
        else
        {

            animator.SetBool("Go", false);
        }

        if (joystick.Horizontal == 0 || joystick.Vertical == 0)
        {
            animator.SetBool("Stop", true);
        }
        else
        {
            animator.SetBool("Stop", false);
        }
    }
}
