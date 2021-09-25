using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigiAdd : MonoBehaviour
{
    public GameObject box;
    private Rigidbody rigi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody component = box.gameObject.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.RightShift))
        {
            if (component == null)
            {
                Debug.Log("Cant find shit");
                box.AddComponent<Rigidbody>();
                rigi = GetComponent<Rigidbody>();
                rigi.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //Adds constraints
            }
                
            
        }
    }
}
