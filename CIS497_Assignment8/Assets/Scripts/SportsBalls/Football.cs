/*****************************************************************************
// File Name :         Football.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/

public class Football : SportsBall
{
    protected override float GetKickForce()
    {
        return 20f;
    }

    protected override string GetName()
    {
        return "Football";
    }
}
