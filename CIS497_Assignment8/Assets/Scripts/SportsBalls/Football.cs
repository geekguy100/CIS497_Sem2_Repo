/*****************************************************************************
// File Name :         Football.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/

using UnityEngine;

public class Football : SportsBall
{
    [SerializeField] private GameObject particleExplosion;

    protected override float GetKickForce()
    {
        return 20f;
    }

    protected override string GetName()
    {
        return "Football";
    }

    protected override void Launch(Vector3 dir)
    {
        base.Launch(dir);
        Instantiate(particleExplosion);
    }
}
