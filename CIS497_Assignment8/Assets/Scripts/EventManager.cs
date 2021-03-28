/*****************************************************************************
// File Name :         EventManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using System;

public static class EventManager
{
    public static event Action<KickData> OnKickOff;

    public static void KickOff(KickData kickData)
    {
        OnKickOff?.Invoke(kickData);
    }
}