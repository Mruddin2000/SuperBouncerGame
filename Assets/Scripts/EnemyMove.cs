using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour {

	public int EnemySpeed;
	public int XMoveDirection;
    public GameObject deathMessage;

    // Update is called once per frame
    void Update() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
        if (hit.distance < 0.9f) {
            Flip();
            if (hit.collider.tag == "Player")
            {
                Destroy(hit.collider.gameObject);
                FindObjectOfType<AudioManager>().Play("PlayerDeath");


                StartCoroutine(DeathMessage());
            }
        }
    }

	void Flip () {
		if (XMoveDirection > 0) {
			XMoveDirection = -2;
		} else {
			XMoveDirection = 2;
		}
	}

    public IEnumerator DeathMessage()
    {
        deathMessage.SetActive(true);

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}