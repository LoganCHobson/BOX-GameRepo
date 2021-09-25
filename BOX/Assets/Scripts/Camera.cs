using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject target;
    public float xoffset, yoffset, zoffset; //We can stack variables this way because they are of the same type. You can spread them out in their own public float if needed.
    public Transform destination;
    public GameObject camera;
    // Update is called once per frame
    void Update()
    {
        camerapos();
    }

    void camerapos()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            xoffset = 4;
            zoffset = 0;
            yoffset = 0;
            transform.position = target.transform.position + new Vector3(xoffset, yoffset, zoffset); //Tells the camera how to move
            transform.LookAt(target.transform.position); //Tells camera to look at player. The LookAt function is literal.
        }

        else if (Input.GetKey(KeyCode.Alpha2))
        {
            //Debug.Log("Teleport");
            camera.transform.position = destination.position;
        }
        else
        {
            xoffset += 0;
            zoffset += 0;
            yoffset += 0;
            transform.position = target.transform.position + new Vector3(xoffset, yoffset, zoffset); //Tells the camera how to move
            transform.LookAt(target.transform.position); //Tells camera to look at player. The LookAt function is literal.
        }
    }
}
