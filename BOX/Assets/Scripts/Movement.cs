using System.Collections; //Libraries
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigi; 
    //Creates a public variable in the inspector that we can manipulate.
    //Public defines the access.
    //Rigidbody specifies the component or game object, depending on what we use.
    //And rigi is just a variable name.

    public float speed = 10f; //Float is one of our interger data types. Interger, double and float are all number data types. int does not like decimals, double does, and float REALLY does.
   
    //These will cover our x and y movements.
    private float x;
    private float z;

    //Void is a function. Void functions do not need to return a variable.
    //Awake is called when the game is loading.
    void Awake()
    {
        rigi = GetComponent<Rigidbody>(); //Alternativly to the public variable, we can request the rigidbody component this way. Unity will find it for us. It is a matter of preference.
    }

    // Update is called once per frame
    private void Update() //Good of taking inputs and animations. Private means that it cannot be changed by another script or from an inspector variable.
    {
        ProccessInputs(); //Calls this function

    }
    private void FixedUpdate() //Good for physics based movement
    {
        Move();
    }

    private void ProccessInputs() //For organization
    {
        x = Input.GetAxis("Horizontal"); //Gives x and z its values or position on the map.
        z = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rigi.AddForce(new Vector3(x, 0f, z) * speed); //Our equation/syntax for movement.
    }
}
