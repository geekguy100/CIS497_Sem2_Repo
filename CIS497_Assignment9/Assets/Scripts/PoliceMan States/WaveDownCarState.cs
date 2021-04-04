/*****************************************************************************
// File Name :         WaveDownCarState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class WaveDownCarState : PoliceManState
{
    private PoliceManStateManager policeManStateManager;

    public WaveDownCarState(PoliceManStateManager policeManStateManager)
    {
        this.policeManStateManager = policeManStateManager;
    }

    public void CheckCar()
    {
        Debug.Log("Cannot check the car while it's still pulling over...");
    }

    public void CompleteCheck()
    {
        Debug.Log("Cannot complete the check since we're waving down the car.");
    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        Debug.Log("We're already waving down a car - no sense pulling over another!");
    }

    public void StartCarCheck()
    {
        Debug.Log("Cop is starting to investigate the car!");
        policeManStateManager.currentState = policeManStateManager.investigateCarState;
    }
}