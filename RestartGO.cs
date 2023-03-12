using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGO : MonoBehaviour
{
    public void Restartus()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
