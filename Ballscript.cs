using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour {
	public GameObject plane;
	public GameObject spawnPoint;
	public GameObject endPoint;
	public GameObject image;
	// Use this for initialization
	void Start () {	
	}
	// Update is called once per frame
	// if ball fall in the direction of y more then 50 units ball position transform to spawnpoint position
	void Update () {
		if (transform.position.y < plane.transform.position.y - 50) {
			transform.position = spawnPoint.transform.position;
		}		
	}
}

