using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) || (Input.GetMouseButtonDown(0)))
        {
            Instantiate(Prefab, SpawnPoint.position + (SpawnPoint.forward * 2), SpawnPoint.rotation);
        }
    }
}
