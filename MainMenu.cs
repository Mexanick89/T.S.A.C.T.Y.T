using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGames()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoHoll()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Shopping()
    {
        SceneManager.LoadScene(2);
    }

    public void World()
    {
        SceneManager.LoadScene(3);
    }

    public void World01()
    {
        SceneManager.LoadScene(4);
    }
}
