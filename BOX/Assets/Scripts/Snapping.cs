using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour
{
    private Transform Destination;
    public float mass;
    private Rigidbody rigi;
    
    // Start is called before the first frame update
    void Awake()
    {
        Destination = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) //So long as we are in this collider.
    {
        if (!Input.GetKey(KeyCode.RightShift))
        {
            if (other.CompareTag("Box"))//Looks for an item with this tag
            {
                other.transform.position = Destination.position;
                rigi = other.GetComponentInParent<Rigidbody>();
                Destroy(rigi, 2);
            }
        }

        if (!Input.GetKey(KeyCode.RightShift))
        {
            if (other.CompareTag("Speed"))//Looks for an item with this tag
            {
                other.transform.position = Destination.position;
                rigi = other.GetComponentInParent<Rigidbody>();
                Destroy(rigi, 2);
            }
        }

        if (!Input.GetKey(KeyCode.RightShift))
        {
            if (other.CompareTag("Bomb"))//Looks for an item with this tag
            {
                other.transform.position = Destination.position;
                rigi = other.GetComponentInParent<Rigidbody>();
                Destroy(rigi, 2);
            }
        }
        if (!Input.GetKey(KeyCode.RightShift))
        {
            if (other.CompareTag("Poison"))//Looks for an item with this tag
            {
                other.transform.position = Destination.position;
                rigi = other.GetComponentInParent<Rigidbody>();
                Destroy(rigi, 2);
            }
        }
        if (!Input.GetKey(KeyCode.RightShift))
        {
            if (other.CompareTag("Metal"))//Looks for an item with this tag
            {
                other.transform.position = Destination.position;
                rigi = other.GetComponentInParent<Rigidbody>();
                Destroy(rigi, 2);
            }
        }

    }
}
