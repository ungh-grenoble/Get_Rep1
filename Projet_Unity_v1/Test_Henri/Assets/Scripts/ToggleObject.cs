using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObject : MonoBehaviour
{
    //ini    
    public InputActionReference togglereference = null; 

    private void Awake()
    {
        togglereference.action.started += Toggle;
        
    }
    private void OnDestroy()
    {
        togglereference.action.started -= Toggle;
    }


    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }


   
}
