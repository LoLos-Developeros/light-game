using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public bool isFiring;

    public bullet bulet;
    public float bulletSpeed;

    public float shots;
    private float shotCounter;

    public Transform firePoint;

    void Start()
    {
        
    }

    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = shots;
                bullet newBullet = Instantiate(bulet, firePoint.position, firePoint.rotation) as bullet;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
