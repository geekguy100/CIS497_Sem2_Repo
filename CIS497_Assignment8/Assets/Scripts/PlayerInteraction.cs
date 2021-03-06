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
    private SportsBall ball = null;

    private RaycastHit lastHit;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, rayLength, whatIsSportsBall))
                ball = hit.transform.GetComponent<SportsBall>();
        }
        else if (ball != null && Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit currentHit;
            Physics.Raycast(ray, out currentHit, rayLength);
            if (currentHit.collider != null)
                lastHit = currentHit;
            else
                currentHit = lastHit;

            ForceCreator.instance.Activate(ball.transform, currentHit.point);
        }
        else if (ball != null && Input.GetMouseButtonUp(0))
        {
            Vector3 dir = ForceCreator.instance.DeactivateAndGetForce();
            ball.Kick(dir);
            ball = null;
        }
    }
}