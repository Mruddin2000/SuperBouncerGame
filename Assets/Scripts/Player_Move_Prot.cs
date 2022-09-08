using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;


public class Player_Move_Prot : MonoBehaviour {

    public int playerSpeed = 5;
    public int playerJumpPower = 1250;
    private float moveX;
    private float moveY;
    public bool isGrounded;
    public float distanceToBottomOfPlayer = 0.9f;
    bool touchingWall;

  

    // Update is called once per frame
    void Update()
    {

        PlayerMove();
		PlayerRaycast ();
  
    }
void PlayerMove() {

        //CONTROLS
        moveX = CrossPlatformInputManager.GetAxis("Horizontal");
        if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
             FindObjectOfType<AudioManager>().Play("Jump");
        }
     

        //ANIMATIONS
        if (moveX != 0) {
			GetComponent<Animator> ().SetBool ("IsRunning", true);
		} else {
			GetComponent<Animator> ().SetBool ("IsRunning", false);
		}
		//PLAYER DIRECTION
		if (moveX < 0.0f )
        {
			GetComponent<SpriteRenderer> ().flipX = true;
           
        } else if (moveX > 0.0f ) {
			GetComponent<SpriteRenderer> ().flipX = false;
        }
		//PHYSICS
		if (touchingWall == false) {
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
		}

        }


    void Jump()
    {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void PlayerRaycast () {
	//Ray Down
		RaycastHit2D rayDown = Physics2D.Raycast (transform.position, Vector2.down);
		if (rayDown != null && rayDown.collider != null && rayDown.distance < distanceToBottomOfPlayer && rayDown.collider.tag == "enemy") {
            GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 1000);
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 200);
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 8;
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().freezeRotation = false;
			rayDown.collider.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			rayDown.collider.gameObject.GetComponent<EnemyMove> ().enabled = false;
		}
		if (rayDown != null && rayDown.collider != null && rayDown.distance < distanceToBottomOfPlayer && rayDown.collider.tag != "enemy") {
			isGrounded = true;
		} 
	}

    
}