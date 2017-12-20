using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp_Camera_Movement : MonoBehaviour {
    public float move;

    //Quick and dirty script to test parallax scrolling
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x + move,this.transform.position.y,this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x - move, this.transform.position.y, this.transform.position.z);
        }
	}
}
