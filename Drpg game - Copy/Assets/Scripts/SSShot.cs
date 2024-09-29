using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSShot : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D r2d;


    // Start is called before the first frame update
    void Start()
    {
        r2d.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemySingleShot enemy = hitInfo.GetComponent<EnemySingleShot>();
        if (enemy != null)
        {
            enemy.TakeDamage(1);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
}