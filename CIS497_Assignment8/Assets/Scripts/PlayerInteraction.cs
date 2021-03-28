/*****************************************************************************
// File Name :         PlayerInteraction.cs
// Author :            Kyle Grenier
// Creation Date :     03/27/2021
//
// Brief Description : Enables interaction with sports balls via mouse clicks.
*****************************************************************************/
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Tooltip("The layer alll sports balls reside on.")]
    [SerializeField] private LayerMask whatIsSportsBall;

    private float rayLength = 20f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, rayLength, whatIsSportsBall))
            {
                SportsBall ball = hit.transform.GetComponent<SportsBall>();
                ball.Kick();
            }
        }
    }
}