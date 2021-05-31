using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D body;
    public float timer;
    public float lifespan;
     

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > lifespan)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
   {
       var enemy = collision.gameObject.GetComponent<Enemy>();
        var enemy2 = collision.gameObject.GetComponent<Enemy2>();

        if (enemy != null)
        {
            //Destroy(enemy.gameObject);
            enemy.death.SetTrigger("Death");
            enemy.dead = true;
            Destroy(gameObject);
        }

        if (enemy2 != null)
        {
            //Destroy(enemy.gameObject);
            enemy2.death.SetTrigger("Death");
            enemy2.dead = true;
            Destroy(gameObject);
        }
    }
}
