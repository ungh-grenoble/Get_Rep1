using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputColorObject : MonoBehaviour
{

    public InputActionReference colorRef = null;
    private MeshRenderer meshR = null; 
    // Start is called before the first frame update
    void Start()
    {
        meshR = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float value = colorRef.action.ReadValue<float>();
        UpdateColor(value); 
        

    }

    private void UpdateColor(float value)
    {
        meshR.material.color = new Color(value, value, value); 
    }
}
