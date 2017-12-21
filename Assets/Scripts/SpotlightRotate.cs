using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightRotate : MonoBehaviour
{
    float calcX, calcY, calcZ;
    float x1, x2, y1, y2, z1, z2;
    int rotation;

    // Use this for initialization
    void Start()
    {
        x1 = transform.rotation.x;
        x2 = x1 * 0.974f;
        y1 = transform.rotation.y;
        y2 = y1 * -1.431f;
        z1 = transform.rotation.z;
        z2 = z1 * -1.065f;

        rotation = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (rotation == 1)
            {
                transform.rotation = new Quaternion(x2, y2, z2, transform.rotation.w);
                rotation = 2;
            }
            else
            {
                transform.rotation = new Quaternion(x1, y1, z1, transform.rotation.w);
                rotation = 1;
            }
        }
    }
}
