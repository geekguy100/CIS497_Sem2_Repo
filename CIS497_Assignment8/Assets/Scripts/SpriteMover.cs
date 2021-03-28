/*****************************************************************************
// File Name :         SpriteMover.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Quaternion startRotation;
    private float yaw;

    [SerializeField] private float sensitivity = 2f;

    private void Start()
    {
        startRotation = transform.localRotation;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
            float v = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;
            yaw -= h;
            yaw -= v;

            print(yaw);
            yaw = Mathf.Clamp(yaw, -360f, 0f);

            Quaternion knobRotation = Quaternion.AngleAxis(yaw, Vector3.forward);
            transform.localRotation = knobRotation * startRotation;
        }
    }
}
