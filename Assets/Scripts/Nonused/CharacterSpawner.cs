using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {

	public GameObject[] players;

	void Start () {
		if (PlayerPrefs.GetInt ("SellectedCharacter") == 0) {
			Instantiate (players [(0)], Vector2.zero, Quaternion.identity);
		}
		if (PlayerPrefs.GetInt ("SellectedCharacter") == 1) {
			Instantiate (players [(1)], Vector2.zero, Quaternion.identity);
		}
	}
}
