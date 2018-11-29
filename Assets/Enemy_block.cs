using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_block : MonoBehaviour {

    public string direction;                //up, left or right
    public GameObject leftborder;           //we have these objects for we can check there position
    public GameObject rightborder;
    public bool canmove;
    bool movedown;

    
    // Use this for initialization
    void Start () {
        direction = "right";
        movedown = false;
        StartCoroutine(stuttereffect());
	}
	
	// Update is called once per frame
	void Update () {

        ///if moving right and the x coordinate of the right most child of enmeyblock is more than the right border, change direction 
        ///do the same for moving left 


        if (canmove) {
            
            Move(direction);
            canmove = false;

        }

        if (transform.childCount == 0) {
            Time.timeScale = 0.3f;
            Debug.Log("YOU WIN!");
        }
        

		
	}

   void Move(string direction) {
        if (movedown) {
            transform.position += new Vector3(0, -1, 0);
            movedown = false;
        }
  

        else if (direction == "right")
        {
                transform.position += new Vector3(1, 0, 0);
        }
        else if (direction == "left") {
                transform.position += new Vector3(-1, 0, 0);
        }


    }

    IEnumerator stuttereffect()
    {
        while (true)
        {
            canmove = !canmove;
            yield return new WaitForSeconds(0.5f);
            
        }
    }


    void OnTriggerEnter(Collider col) {
        if (col.name == "Rightborder") {
            Debug.Log("hti");
            direction = "left";
            movedown = true;
        }
        else if (col.name == "Leftborder")
        {
            Debug.Log("hti");
            direction = "right";
            movedown = true;
        }

    }

}
