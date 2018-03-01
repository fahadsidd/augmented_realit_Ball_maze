using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	public GameObject ball;
	public GameObject image;
	// Use this for initialization
	Vector3 tempPos;
	Vector3 ballPos;

	void Start () {
		
	}

	// Update is called once per frame
	void Update ()

	
		{
		ballPos = ball.transform.position;
			if (ballPos.x < -0.31 && ballPos.y < -0.355) 
			
		{
				tempPos = transform.position;
				tempPos.x += 3f * Time.deltaTime;
				transform.position = tempPos;
			}
		}
	}
