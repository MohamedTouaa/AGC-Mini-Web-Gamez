using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float move;
    public Rigidbody2D rb;
    public int lives;

    public Transform firePoint;
    public GameObject bullet;
    public Transform enemiesCount;
    float t = 0;


    void Awake()
    {
        lives = 3;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 10f;
        print(lives);
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        t += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && t >= 0.5)
        {
            Shoot();
            t = 0;
        }
        Die();
        boss();
        

    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    void Die()
    {
        if(lives <= 0)
        {
            Destroy(gameObject);
        }
    }

    void boss()
    {
        if(enemiesCount.childCount == 0)
        {

        }
    }
}
