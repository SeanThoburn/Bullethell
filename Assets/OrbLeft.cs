using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbLeft : MonoBehaviour
{
    public Rigidbody2D body;
    public float timer;
    public float lifespan;


    private void FixedUpdate()
    {

        body.AddForce(new Vector2(-6f, 0f));


        timer += Time.deltaTime;

        if (timer > lifespan)
            Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerScript>();
        player.death.SetTrigger("death");
    }
}
