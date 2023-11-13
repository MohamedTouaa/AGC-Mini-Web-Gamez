using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShips : MonoBehaviour
{
    //public Player player;
    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Player player = c.GetComponent<Player>();
        
        print(player.lives);
        if (c.CompareTag("Player"))
        {
            print(player.lives);
            player.lives--;
            print(player.lives);
            Destroy(gameObject);
        }
    }
}
