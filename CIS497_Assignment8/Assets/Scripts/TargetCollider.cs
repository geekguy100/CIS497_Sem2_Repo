/*****************************************************************************
// File Name :         TargetCollider.cs
// Author :            Kyle Grenier
// Creation Date :     03/27/2021
//
// Brief Description : Defines the behaviour for when a sports ball collides with the target.
*****************************************************************************/
using UnityEngine;

public class TargetCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Sportsball"))
        {
            print("TARGET HIT!!");
            ScoreManager.Score += 1;
            EventManager.TargetHit();
        }
    }
}