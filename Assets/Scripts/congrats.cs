using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class congrats : MonoBehaviour
{
    public GameObject winMessage;

    /* This is a new variable which is using a in game method (gameobject) to assign the text which will display the winmessage to the variable.  this will then allow me to run the the code so that the message will be shown when the condition has been met.*/

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("SpA");
            StartCoroutine(WinMessage());
        }
    }
    /* Here I'm using */

    public IEnumerator WinMessage()
    {
        winMessage.SetActive(true);

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}