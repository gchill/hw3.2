using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }
    public void Quit()
    {
        SceneManager.LoadScene("end");
    }
    public void End()
    {
       Application.Quit();
    }
}
