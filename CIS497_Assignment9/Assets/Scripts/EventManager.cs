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
    public static event Action<CarCommunicator> OnCarSpawn;
    public static event Action OnCarDespawn;

    public static event Action<PoliceManState> OnPoliceManStateChange;
    public static event Action<string> OnPoliceManTalk;


    public static void CarSpawn(CarCommunicator carCommunicator)
    {
        OnCarSpawn?.Invoke(carCommunicator);
    }

    public static void CarDespawn()
    {
        OnCarDespawn?.Invoke();
    }

    public static void PoliceManStateChange(PoliceManState state)
    {
        OnPoliceManStateChange?.Invoke(state);
    }

    public static void PoliceManTalk(string text)
    {
        OnPoliceManTalk?.Invoke(text);
    }
}