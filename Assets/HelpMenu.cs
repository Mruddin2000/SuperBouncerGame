using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour
{
    public void Help()
    {
        FindObjectOfType<AudioManager>().Play("ButtonHover");
        FindObjectOfType<AudioManager>().Play("ButtonPressed");


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

