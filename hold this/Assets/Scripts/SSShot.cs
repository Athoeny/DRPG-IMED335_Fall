using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSShot : MonoBehaviour
{
    public GameObject ssShotPrefab;
    public Transform playerPosition;

    public float bulletSpeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(playerPosition);
            Instantiate(ssShotPrefab, playerPosition.position, Quaternion.identity);
        }
    }
}
