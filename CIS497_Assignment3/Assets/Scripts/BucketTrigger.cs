/*****************************************************************************
// File Name :         BucketTrigger.cs
// Author :            Kyle Grenier
// Creation Date :     02/11/2021
//
// Brief Description : Controls what occurs when a Collider2D enters the trigger.
*****************************************************************************/
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        EventManager.BucketTrigger();
        Destroy(col.transform.parent.gameObject);
    }
}
