﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject knife;

    private float min_X = -1f;
    private float max_X = 1.5f;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
	}
	
    IEnumerator StartSpawning() {
        yield return new WaitForSeconds(Random.Range(0.2f, 0.8f));

        GameObject k = Instantiate(knife);

        float x = Random.Range(min_X, max_X);

        k.transform.position = new Vector2(x, transform.position.y);

        StartCoroutine(StartSpawning());

    }
    void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }


} // class






















