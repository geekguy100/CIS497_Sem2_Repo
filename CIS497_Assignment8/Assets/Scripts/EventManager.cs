/*****************************************************************************
// File Name :         EventManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Class to handle subscribing / unsubscribing to and invoking game events.
*****************************************************************************/
using System;

public static class EventManager
{
    public static event Action<KickData> OnKickOff;
    public static event Action OnTargetHit;

    public static void KickOff(KickData kickData)
    {
        OnKickOff?.Invoke(kickData);
    }

    public static void TargetHit()
    {
        OnTargetHit?.Invoke();
    }
}