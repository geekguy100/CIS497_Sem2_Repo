/*****************************************************************************
// File Name :         DestroyOnContact.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Destroys any game object that comes into contact with this game object.
*****************************************************************************/
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
