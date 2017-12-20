using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBulbMovement : MonoBehaviour {

    float playerBulbMoveSpeed;
    float enemyBulbMoveSpeed;
    float moveSpeed;
    GameObject timeTable;
    float timeTableRightBound;
    bool move;
    Vector3 startPos;

    void Start () {

        playerBulbMoveSpeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TimeManager>().playerBulbMoveSpeed;
        enemyBulbMoveSpeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TimeManager>().enemyBulbMoveSpeed;
        timeTable = GameObject.FindGameObjectWithTag("TimeTableSprite");
        timeTableRightBound = timeTable.GetComponent<SpriteRenderer>().bounds.extents.x;
        startPos = transform.position;

        switch (name)
        {
            case "Bulb Enemy":
                {
                    moveSpeed = 1 * enemyBulbMoveSpeed;
                    this.transform.position = new Vector3(timeTableRightBound * -0.83f, this.transform.position.y, this.transform.position.z);
                }
                break;

            case "Bulb Player":
                {
                    this.transform.position = new Vector3(timeTableRightBound * 0.45f, this.transform.position.y, this.transform.position.z);
                    moveSpeed = 1 * playerBulbMoveSpeed;
                }
                break;
        }
	}
	
	void FixedUpdate () {
        if(Input.GetKeyDown(KeyCode.T))
        {
            move = !move;
            Debug.Log("Bulb movement: " + move);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
        }

        if (move)
        {
            if (this.name == "Bulb Enemy")
            {
                if (this.transform.position.x <= timeTableRightBound * -0.58f)
                {
                    transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
                }
                else
                {
                    move = false;
                }
            }

            if (this.name == "Bulb Player")
            {
                if (this.transform.position.x <= timeTableRightBound * 0.90)
                {
                    transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
                }
                else
                {
                    move = false;
                }
            }
        }
    }
}
