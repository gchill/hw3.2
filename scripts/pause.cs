using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    private bool isPause;
    public GameObject pauseText;
    public GameObject spawn;

    void Start()
    {
        pauseText.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pauseText.SetActive(true);
            spawn.SetActive(false);
        }
        else if(Input.GetKeyDown("escape"))
        {
            pauseText.SetActive(false);
            spawn.SetActive(true);
        }
    }
}
