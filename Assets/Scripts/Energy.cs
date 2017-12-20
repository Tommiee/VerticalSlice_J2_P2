using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is for the draining energy bar of igniculius
public class Energy : MonoBehaviour {

    Vector3 startSize;
    Vector3 startPos;
    float posChange;
    float scaleChange;
    bool move;
    public float moveSpeed;

	void Start () {
        startSize = transform.localScale;
        startPos = transform.position;
        move = false;
        posChange = -moveSpeed * transform.parent.transform.localScale.x; 
        scaleChange = -0.08f;
    }   
	
	void Update () {
        posChange = -moveSpeed * transform.parent.transform.localScale.x;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            move = !move;
        }

        if (transform.localScale.x <= 0)
        {
            move = false;
        }

        if(move)
        {
            transform.position = new Vector3(transform.position.x + (posChange * Time.deltaTime), transform.position.y, transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x + (scaleChange * Time.deltaTime), transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
            transform.localScale = startSize;
        }
    }
}
