using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public Material greyMat = null;
    public Material pinkMat = null;


    private MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabInteractable = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(SetColorPink);
        grabInteractable.onDeactivate.AddListener(SetColorGrey);
    }

    private void OnDestroy()
    {
        grabInteractable.onActivate.RemoveListener(SetColorPink);
        grabInteractable.onDeactivate.RemoveListener(SetColorGrey);

    }
    private void SetColorPink(XRBaseInteractor interactor)
    {
        meshRenderer.material = pinkMat; 
    }
    private void SetColorGrey(XRBaseInteractor interactor)
    {
        meshRenderer.material = greyMat;
    }
}
