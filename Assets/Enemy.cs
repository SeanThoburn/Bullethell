using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float lifespan;
    public float timer;
    public bool dead;

    public Animator death;
    public Rigidbody2D body;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > lifespan)
            Destroy(gameObject);

        if (dead == false)
        {
            body.velocity = new Vector2(0f, -2f);
        }
        else
        {
            body.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (dead)
        {
            return;
        }

        var player = collision.gameObject.GetComponent<PlayerScript>();
        player.death.SetTrigger("death");
    }

    public void kill()
    {
        FindObjectOfType<game>().score += 50;

        FindObjectOfType<game>().timeleft += 5;
        Destroy(gameObject);
    }

}
