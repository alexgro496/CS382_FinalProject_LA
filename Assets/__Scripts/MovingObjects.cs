using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    public GameObject myCharacter;
    bool canpickup;
    GameObject ObjectIwantToPickUp;
    bool hasItem;

    bool itemPickedUp;

    void Start()
    {
        canpickup = false;
        hasItem = false;
    }

    void Update()
    {
        if(canpickup == true)
        {
            if (Input.GetKeyDown("e"))
            {
                hasItem = true;
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = true;   
                ObjectIwantToPickUp.transform.position = myCharacter.transform.position; 
                ObjectIwantToPickUp.transform.parent = myCharacter.transform;
            }
            if (Input.GetKeyDown("q") && hasItem == true)
            {
            ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = false;
         
            ObjectIwantToPickUp.transform.parent = null;

            hasItem = false;

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            canpickup = true;
            ObjectIwantToPickUp = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        canpickup = false;
    
    }
}

