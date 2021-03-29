/*****************************************************************************
// File Name :         Tennisball.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/

public class Tennisball : SportsBall
{
    protected override float GetKickForce()
    {
        return 25f;
    }

    protected override string GetName()
    {
        return "Tennisball";
    }
}
