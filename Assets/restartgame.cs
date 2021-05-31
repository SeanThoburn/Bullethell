using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour
{
    public void startagain()
    {
        SceneManager.LoadScene("BulletHell");
        Time.timeScale = 1f;
    }

}
