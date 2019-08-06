using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
        //if (gameObject.tag == "bolt")
        //{
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        //}
  //          if (gameObject.tag == "ebolt")
    //    {
     //       GetComponent<Rigidbody>().velocity = (transform.up * speed);
       // }
	}
	
	//this script has been edited 
}
