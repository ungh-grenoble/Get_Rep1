using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closecanva : MonoBehaviour
{

    public GameObject wall_canva;
    public GameObject finish_canva;



    public void CloseCanvaWall()
    {
        wall_canva.SetActive(false); 
    }

    public void CloseCanvaFinish()
    {
        finish_canva.SetActive(false);
    }
}

