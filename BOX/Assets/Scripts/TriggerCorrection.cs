using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCorrection : MonoBehaviour
{
    public Transform parent;
    private Collider col;
    
    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        col.isTrigger = false;
        transform.position = parent.position;
    }
}
