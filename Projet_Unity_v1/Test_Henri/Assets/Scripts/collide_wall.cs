using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide_wall : MonoBehaviour
{
    public GameObject wall_canva;
    public GameObject finish_canva;


    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wall")
        {
            wall_canva.SetActive(true); 
        }

        if (col.gameObject.tag == "finish")
        {
            finish_canva.SetActive(true);
        }
    }
    


    
}
