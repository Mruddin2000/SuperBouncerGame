using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("ButtonHover");
        FindObjectOfType<AudioManager>().Play("ButtonPressed");


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("Background");

    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

        FindObjectOfType<AudioManager>().Play("ButtonHover");
        FindObjectOfType<AudioManager>().Play("ButtonPressed");
    }
}
