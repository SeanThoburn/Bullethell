using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    public bullet bulletprefab;
    public float bulletspeed;
    public float bullettime;
    public float firerate;

    public Animator death;
    public GameObject restart;


    private void FixedUpdate()
    {
        bullettime += Time.deltaTime;

        if (bullettime > firerate)
        {
            bullettime = firerate;

        }

        body.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed));
        if (Input.GetButton("Jump") && bullettime >= firerate)
        {
            bullettime -= firerate;

            var pew = Instantiate<bullet>(bulletprefab);
            pew.transform.position = transform.position;
            pew.body.AddForce(new Vector2(0f, bulletspeed));

        }


    }

    public void kill()
    {
        Destroy(gameObject);
    }
    public void gameover()
    {
        Time.timeScale = 0;
        restart.gameObject.SetActive(true);        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.death.SetTrigger("Death");
            enemy.dead = true;
        }

    }
}
