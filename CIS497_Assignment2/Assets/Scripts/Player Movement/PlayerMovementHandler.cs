using UnityEngine;

[RequireComponent(typeof(RocketMovement))]
public class PlayerMovementHandler : MonoBehaviour
{
    private RocketMovement movement;

    private void Awake()
    {
        movement = GetComponent<RocketMovement>();
    }

    private void Update()
    {
        //Moves the rocket up and down, given input, over time.
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(h, v, 0);

        movement.Move(dir);
    }
}
