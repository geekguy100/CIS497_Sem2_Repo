using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float horizontalMovementMultiplier = 0.5f;

    [Header("Movement Boundries")]
    [SerializeField] private float xBoundryOffset = 0f;
    [SerializeField] private float yBoundryOffset = 0f;

    /// <summary>
    /// Moves the rocket in the given direction.
    /// </summary>
    /// <param name="dir">The direction in which to move the rocket.</param>
    public void Move(Vector3 dir)
    {
        //Taking the horizontal movement multiplier into account.
        dir.x *= horizontalMovementMultiplier;

        Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0 + yBoundryOffset));
        Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1 - xBoundryOffset, 1 - yBoundryOffset));

        //Making sure the transform's position stays within the designated boundries.
        Vector3 pos = transform.position;
        pos += dir * movementSpeed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        //Updating the transform's position.
        transform.position = pos;
    }
}
