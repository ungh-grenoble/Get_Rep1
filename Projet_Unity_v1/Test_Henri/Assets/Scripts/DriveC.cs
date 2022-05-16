using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DriveC : MonoBehaviour
{
    //ini
    public Transform setparent =  null ; 
    public InputActionReference drivingreference = null;
    private bool touchedKart = false;
    public GameObject canva; 
    
    private void Awake()
    {
        drivingreference.action.started += Drive;
    }
    private void OnDestroy()
    {
        drivingreference.action.started -= Drive;
    }
    /*
    void OntriggerStay(Collision col)
    {
        if (col.gameObject.tag == "hand")
        {
            touchedKart = true;
            Debug.Log("Kart touched!");

        }
        else { touchedKart = false;  }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="wall")
        {
            canva.SetActive(true);
        }
    }

    private void Drive(InputAction.CallbackContext context)
    {
        //gameObject.transform.SetParent(setparent);


        
        if (gameObject.transform.parent== null) // && touchedKart
        {
            gameObject.transform.SetParent(setparent);
        }
        else
        {
            gameObject.transform.SetParent(null);
        }
          

    }


}

