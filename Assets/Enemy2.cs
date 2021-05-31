using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float lifespan;
    public float timer;
    public float timer2;
    public bool dead;

    public Animator death;
    public Rigidbody2D body;

    public float fireRate;
    public OrbRight rightprefab;
    public OrbLeft leftprefab;
    public OrbUp upprefab;
    public OrbDown downprefab;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (timer > lifespan)
            Destroy(gameObject);

        if (dead == false)
        {
            body.velocity = new Vector2(0f, -1f);
        }
       else
        {
            body.velocity = new Vector2(0f, 0f);
        }
        if (timer2 > fireRate)
        {
            var orbr = Instantiate<OrbRight>(rightprefab);
           orbr.transform.position = transform.position;

            var orbl = Instantiate<OrbLeft>(leftprefab);
            orbl.transform.position = transform.position;

            var orbu = Instantiate<OrbUp>(upprefab);
            orbu.transform.position = transform.position;

            var orbd = Instantiate<OrbDown>(downprefab);
            orbd.transform.position = transform.position;

            timer2 = 0f;
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
        FindObjectOfType<game>().score += 100;

        FindObjectOfType<game>().timeleft += 5;
        Destroy(gameObject);
    }

}
