using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    //Timers for basic enemies
    public float enenmytimer;
    public float enenmytimer2;
    public float enenmytimer3;
    public float enenmytimer4;
    public float enenmytimer5;
    public float enenmytimer6;
    public float enenmytimer7;
    public float enenmytimer8;

    //timers for second enemy
    public float enenmy2timer;
    public float enenmy2timer2;
    public float enenmy2timer3;
    public float enenmy2timer4;
    public float enenmy2timer5;
    public float enenmy2timer6;

    //controllers for enemy spawns
    public float enemyrate;
    public float enemy2rate;
    public float enemy2rate2;
    public Enemy enemyprefab;
    public Enemy2 enemy2prefab;

    //core game options
    public int score;
    public float gameTime;
    public Text scoretext;
    public Text timertext;
    public float timeleft;
    public Text timelimit;
    public GameObject restart;

    private void FixedUpdate()
    {
        enenmytimer += Time.deltaTime;
        enenmytimer2 += Time.deltaTime;
        enenmytimer3 += Time.deltaTime;
        enenmytimer4 += Time.deltaTime;
        enenmytimer5 += Time.deltaTime;
        enenmytimer6 += Time.deltaTime;
        enenmytimer7 += Time.deltaTime;
        enenmytimer8 += Time.deltaTime;

        enenmy2timer += Time.deltaTime;
        enenmy2timer2 += Time.deltaTime;
        enenmy2timer3 += Time.deltaTime;
        enenmy2timer4 += Time.deltaTime;
        enenmy2timer5 += Time.deltaTime;
        enenmy2timer6 += Time.deltaTime;


        gameTime += Time.deltaTime;

        if (enenmytimer > enemyrate)
        {
            enenmytimer = 0f;

            var enemy = Instantiate<Enemy>(enemyprefab);

            enemy.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
        }

        if (score > 500)
        {
            if (enenmytimer2 > enemyrate)
            {
                enenmytimer2 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-2f, 2f), 4f);
            }
            if (enenmy2timer > enemy2rate2)
            {
                enenmy2timer = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 1000)
        {
            if (enenmytimer3 > enemy2rate)
            {
                enenmytimer3 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 2000)
        {
            if (enenmytimer4 > enemy2rate)
            {
                enenmytimer4 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), 4f);
            }

            if (enenmy2timer2 > enemy2rate)
            {
                enenmy2timer2 = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 3000)
        {
            if (enenmytimer5 > enemy2rate)
            {
                enenmytimer5 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), 4f);
            }

            if (enenmy2timer3 > enemy2rate)
            {
                enenmy2timer3 = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 4000)
        {
            if (enenmytimer6 > enemy2rate)
            {
                enenmytimer6 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), 4f);
            }

            if (enenmy2timer4 > enemy2rate)
            {
                enenmy2timer4 = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 5000)
        {
            if (enenmytimer7 > enemyrate)
            {
                enenmytimer7 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), 4f);
            }

            if (enenmy2timer5 > enemy2rate)
            {
                enenmy2timer5 = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }

        if (score > 6000)
        {
            if (enenmytimer8 > enemy2rate)
            {
                enenmytimer8 = 0f;

                var enemy = Instantiate<Enemy>(enemyprefab);

                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), 4f);
            }

            if (enenmy2timer6 > enemy2rate)
            {
                enenmy2timer6 = 0f;

                    var enenmy2 = Instantiate<Enemy2>(enemy2prefab);

                enenmy2.transform.position = new Vector3(Random.Range(-3f, 3f), 4f);
            }
        }


        scoretext.text = score.ToString();
        timertext.text = gameTime.ToString();
        timelimit.text = timeleft.ToString();



        if (gameTime > timeleft)
        {
            restart.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            restart.gameObject.SetActive(false);
        }

    }
}
