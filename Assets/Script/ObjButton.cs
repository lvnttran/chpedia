using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public XRBaseInteractor interactor; // Reference to the XRBaseInteractor

    private void Start()
    {
        // Get reference to XRBaseInteractor component
        interactor = GetComponent<XRBaseInteractor>();

        // Subscribe to the SelectEntered event
        interactor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Invoke the UnityEvent when the object is selected
        unityEvent.Invoke();
    }
}
