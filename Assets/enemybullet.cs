using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
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
}
