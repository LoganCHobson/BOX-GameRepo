using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public enum PICKUP {Empty, Full} //We can define GameStatest with enums. Must be outside of the class. 
public class PlayerInteract : MonoBehaviour
{
    public float speed = 100f;
    public Transform Player;
    public Text detonation;
    public Text healthtxt;
    public float countDown = 10;
    public float health = 100;
    public PICKUP state;

    bool poison = false;
    bool active = false;
    [HideInInspector]
    public bool end = false;

    [HideInInspector]
    public GameObject bombobj;

   
    

    // Update is called once per frame
    void Start()
    {
        state = PICKUP.Empty;
    }
    
    void FixedUpdate()
    {
        bomb();
        Poison();
    }

    private void OnTriggerStay(Collider other) //So long as we are in this collider.
    {
        if (other.CompareTag("Box") && state != PICKUP.Full)//Looks for an item with this tag
        {
            speed = 10f;
            if (Input.GetKey(KeyCode.RightShift))
            {
                 other.transform.position = Player.position;
                    state = PICKUP.Full;
                // Debug.Log("Grabbed");
            }
        }

        if (other.CompareTag("Bomb") && state != PICKUP.Full)
        {
            speed = 10f;
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.transform.position = Player.position;
                bombobj = other.gameObject; //Takes the collider, finds its game object and the stores it in bombobj
                state = PICKUP.Full;
                active = true;
            }
        }

        if (other.CompareTag("Speed") && state != PICKUP.Full)
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.transform.position = Player.position;
                state = PICKUP.Full;
                speed = 15f;
            }
        }
        
        if (other.CompareTag("Metal") && state != PICKUP.Full)
        {
            speed = 2f;
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.transform.position = Player.position;
                state = PICKUP.Full;
            }
        }

        if (other.CompareTag("Poison") && state != PICKUP.Full)
        {
            speed = 10f;
            if (Input.GetKey(KeyCode.RightShift))
            {
                other.transform.position = Player.position;
                state = PICKUP.Full;
                poison = true;
            }
        }

        else
        {
            state = PICKUP.Empty;
        }
    }

    void bomb()
    {
        if (active == true)
        {
            if (countDown > 0)
            {
                countDown -= Time.deltaTime;
                countDown = Mathf.Round(countDown * 100.0f) * 0.01f;
                detonation.text = "Detonation in: " + countDown.ToString();
            }

            if (countDown <= 0)
            {
                end = true;
                active = false;
                countDown = 10;
            }
        }

        else
        {
            detonation.text = "A bomb!";
            active = false;
            end = false;
        }
    }
    void Poison()
    {
        if (poison == true)
        {
            health -= Time.deltaTime;
            health = Mathf.Round(health * 100000.0f) * 0.00001f;
            healthtxt.text = "Health: " + health.ToString();

            if (health <= 0)
            {
                Debug.Log("Die");
                poison = false;
            }
            

        }
        else
        {
            poison = false;
        }
    }
    private void OnTriggerExit(Collider other) //So long as we are in this collider.
    {
        speed = 10f;
    }
}
