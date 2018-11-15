using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_block : MonoBehaviour {

    public string direction;                //up, left or right
    public GameObject leftborder;           //we have these objects for we can check there position
    public GameObject rightborder;
    public bool canmove;

    
    // Use this for initialization
    void Start () {
        
        StartCoroutine(stuttereffect());
	}
	
	// Update is called once per frame
	void Update () {

        ///if moving right and the x coordinate of the right most child of enmeyblock is more than the right border, change direction 
        ///do the same for moving left 


        if (canmove) {
            
            Move(direction);

        }
        

		
	}

   void Move(string direction) {


    }

    IEnumerator stuttereffect()
    {
        while (true)
        {
            canmove = !canmove;
            yield return new WaitForSeconds(0.5f);
            
        }
    }


}
