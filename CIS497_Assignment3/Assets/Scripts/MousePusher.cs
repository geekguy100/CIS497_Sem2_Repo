/*****************************************************************************
// File Name :         MousePusher.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Raycast on mouse position and push any rigidbodies in direction of mouse movement.
                       Activate my holding down left mouse button.
*****************************************************************************/
using UnityEngine;

public class MousePusher : MonoBehaviour
{
    [SerializeField] private float pushForce = 4f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Find mouse position, camera position, and direction from camera to mouse.
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 origin = Camera.main.transform.position;
            Vector2 dir = (pos - origin).normalized;

            //Send out a raycast from camera to mouse position.
            RaycastHit2D hit = Physics2D.Raycast(origin, dir);

            //If the ray hit a Ball, push it!
            if (hit && hit.transform.CompareTag("Ball"))
            {
                PushRigidbody2D(hit.transform.GetComponent<Rigidbody2D>());
            }
        }
    }

    /// <summary>
    /// Push a Rigidbody2D in the direction of mouse movement. Left mouse button must be held.
    /// </summary>
    /// <param name="rb">The Rigidbody2D to push.</param>
    private void PushRigidbody2D(Rigidbody2D rb)
    {
        Vector2 mouseVel = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        print(mouseVel);
        Vector2 force = mouseVel * pushForce;
        rb.AddForce(force, ForceMode2D.Force);
    }
}
