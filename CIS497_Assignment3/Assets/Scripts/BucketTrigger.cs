/*****************************************************************************
// File Name :         BucketTrigger.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        print(col.gameObject.name + " in bucket");
    }
}
