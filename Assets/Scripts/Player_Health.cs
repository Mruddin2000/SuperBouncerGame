using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {
    public GameObject deathMessage;
    public bool isDeath;

    void Update()
    {
        if (isDeath == false)
        {
            if (gameObject.transform.position.y < -15)
            {
                Die();
            }
        }

    }

    void Die()
    {
        isDeath = true;

        StartCoroutine(DeathMessage());
    }

    public IEnumerator DeathMessage()
    {
        deathMessage.SetActive(true);

        FindObjectOfType<AudioManager>().Play("PlayerDeath");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
