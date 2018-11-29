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

    void OnTriggerEnter(Collider collision)  //This method is called when the object collides with something
    {
        Debug.Log("yeet");
        if (collision.gameObject.tag == "Enemy") {
            Destroy(collision.gameObject);
        }
        //When bullets collide they are both destroyed 
    }
}
