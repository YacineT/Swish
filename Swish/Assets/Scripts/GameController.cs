﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Basketball;
    public static Vector3 ballStart = new Vector3(3f, 1f, 0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
            Instantiate(Basketball, ballStart, Quaternion.identity);

    }

    public void CreateBall()
    {
        Instantiate(Basketball, ballStart, Quaternion.identity);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.name.Equals("Net1"))
            Debug.Log("Made it!");
    }

}
