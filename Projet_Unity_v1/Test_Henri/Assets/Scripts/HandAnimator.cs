using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAnimator : MonoBehaviour
{
    public float speed = 5.0f;
    public XRController controller = null;

    private Animator animator = null;
    private readonly List<Finger> gripfingers = new List<Finger>()
    {
        new Finger(FingerType.Middle),
        new Finger(FingerType.Ring),
        new Finger(FingerType.Pinky)
    };

    private readonly List<Finger> pointfingers = new List<Finger>()
    {
        new Finger(FingerType.Index),
        new Finger(FingerType.Thumb)
       
    };


    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        // Check inputs 
        CheckGrip();
        CheckPointer();

        //Smooth values 
        SmoothFinger(pointfingers);
        SmoothFinger(gripfingers);

        //Apply smooth values

        AnimateFinger(pointfingers);
        AnimateFinger(gripfingers);

        

    }

    private void CheckGrip()
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue)) SetFingerTargets(gripfingers, gripValue); 
    }

    private void CheckPointer()
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float pointerValue)) SetFingerTargets(gripfingers, pointerValue);

    }

    private void SetFingerTargets(List<Finger> fingers, float value)
    {
        foreach(Finger f in fingers)
        {
            f.target = value; 

        }

    }

    private void SmoothFinger(List<Finger> fingers)
    {
        foreach (Finger f in fingers)
        {
            float time = speed * Time.unscaledDeltaTime; // in case there is paused in the game 
            f.current = Mathf.MoveTowards(f.current, f.target, time); 


        }

    }

    private void AnimateFinger(List<Finger> fingers)
    {
        foreach (Finger f in fingers)
            AnimateFinger(f.type.ToString(), f.current); 


    }

    private void AnimateFinger(string finger, float blend)
    {
        animator.SetFloat(finger, blend); 
    }
}