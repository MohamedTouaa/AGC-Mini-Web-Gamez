using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 6f;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        enemy Enemy = hitInfo.GetComponent<enemy>();

        if (hitInfo.name == "enemy")
        {
            Enemy.takeDamage(1);
            Destroy(gameObject);
        }
        else if (hitInfo.CompareTag("boundry"))
        {
            Destroy(gameObject);
        }

    }
}
