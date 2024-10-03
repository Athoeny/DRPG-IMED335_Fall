using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    private Rigidbody r2d;
    private int targetX;
    private int targetY;
    public GameObject target;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            triggerActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("exit");
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("button pressed");
            SpawnTargets();
        }
    }

    public void SpawnTargets()
    {
        Debug.Log("spawn attempt");
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-8, 9), Random.Range(-2,3), 0);
        Instantiate(target, randomSpawnPosition,Quaternion.identity);
    }

}