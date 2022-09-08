using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

	private GameObject player; /* This is a new variable to find the player. As the Player has its own Tag in unity, i'm using GameObejct method to find the Player tag from unity.*/
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

    /* These are new variables which are created in public mode to get access through unity. This will allows you to set the minimum and maximum range where the camera should move. i've create both for y and x axis, so that the camera could move up and down as well as moving left to right. I've used float method to assign the variables that the value will be number.*/


	// Use this for initialization
	void Start () {
		if (GameObject.FindGameObjectWithTag ("Player") != null) { /*I'm using "void Start" method to declare the camera to look for the player tag as soon as the game starts. I'm also using If statement to tell the camera that if the player isn't found then don't show an error. if the player is found then just follow the player.*/

			player = GameObject.FindGameObjectWithTag ("Player");
           		}
	}

    // Update is called once per frame
    void LateUpdate () { /*I've used LateUpdate method to update the frame after game starts, so that it tracks objcts.*/
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
			float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);
			gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);

            /* Here I'm using the two new variables x and y to assign them to public varables with the minimum and maximum value of x and y. This will help the camera to workout where the positioning of the camera should be in. */ 
		}
	}
}
