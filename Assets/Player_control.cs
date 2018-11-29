using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour {

    public GameObject leftborder, rightborder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //Input.GetKeyDown to move and to fire
        //remember to constrain player position to between the two borders (leftborder.x<player.x<right.border)
        // use Instatiation to create bullets



	}


    void OnCollisionEnter(Collision col)  //This method is called when the object collides with something
    {
        //Did an enemy bullet hit me?
        if (col.gameObject.tag == "Enemy") {
            Time.timeScale = 0;
            Debug.Log("YOU LOSE!");
        }
    }

}
