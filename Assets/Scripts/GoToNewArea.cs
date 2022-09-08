using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNewArea : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public GameObject sp1, sp2;

    void Start()
    {
        sp1 = this.gameObject;
    }

    void OnTriggerStay2D(Collider2D trig)
    {
        if (Input.GetButtonDown("Jump"))
        {
            trig.gameObject.transform.position = sp2.gameObject.transform.position;
        }
    }
}
