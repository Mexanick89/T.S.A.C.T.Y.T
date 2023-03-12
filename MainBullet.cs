using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBullet : MonoBehaviour
{
    public float life = 3;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
