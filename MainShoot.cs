using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShoot : MonoBehaviour
{
    [SerializeField] AudioSource shootinGun;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;


    public void Shooting()
    {
        shootinGun.Play();
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
