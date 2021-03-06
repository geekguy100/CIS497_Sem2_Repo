/*****************************************************************************
// File Name :         HoverPad.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : Behaviour for the hover pad - levitates rigidbodies.
*****************************************************************************/
using UnityEngine;

public class HoverPad : MonoBehaviour
{
    private new bool enabled = false;
    public bool Enabled { get { return enabled; } }

    [SerializeField] private GameObject centerMat;
    [SerializeField] private float force;
    private BoxCollider boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    public void TurnOn()
    {
        Enable();
    }

    public void TurnOff()
    {
        Disable();
    }

    private void Enable()
    {
        enabled = true;
        centerMat.GetComponent<MeshRenderer>().material.color = Color.green;
        boxCollider.enabled = true;
    }

    private void Disable()
    {
        enabled = false;
        centerMat.GetComponent<MeshRenderer>().material.color = Color.red;
        boxCollider.enabled = false;
    }

    private void OnTriggerStay(Collider col)
    {
        Rigidbody rb = col.GetComponent<Rigidbody>();
        if (rb != null)
            rb.AddForce(Vector3.up * force, ForceMode.Force);
    }
}
