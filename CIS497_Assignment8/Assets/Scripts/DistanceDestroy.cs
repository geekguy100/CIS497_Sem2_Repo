/*****************************************************************************
// File Name :         DistanceDestroy.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Destroys the GameObject if it is a set distance away from (0,0,0).
*****************************************************************************/
using UnityEngine;

public class DistanceDestroy : MonoBehaviour
{
    [SerializeField] private float maxDistance = 50f;

    private void Update()
    {
        if (Vector3.Distance(Vector3.zero, transform.position) > maxDistance)
            Destroy(gameObject);
    }
}
