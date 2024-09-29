using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SSShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject ssShot;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        Instantiate(ssShot, firePoint.position, firePoint.rotation);
    }
}
