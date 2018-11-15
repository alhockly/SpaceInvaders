using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)  //This method is called when the object collides with something
    {
        //When bullets collide they are both destroyed 
    }
}
