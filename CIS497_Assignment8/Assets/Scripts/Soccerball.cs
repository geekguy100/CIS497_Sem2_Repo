/*****************************************************************************
// File Name :         Soccerball.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/

public class Soccerball : SportsBall
{
    protected override float GetKickForce()
    {
        return 10f;
    }

    protected override string GetName()
    {
        return "Soccerball";
    }
}
