/*****************************************************************************
// File Name :         PoliceManCompleteCheckState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class PoliceManCompleteCheckState : PoliceManState
{
    private PoliceManStateManager stateManager;

    public PoliceManCompleteCheckState(PoliceManStateManager stateManager)
    {
        this.stateManager = stateManager;
    }

    public void CheckCar()
    {
        throw new System.NotImplementedException();
    }

    public void CompleteCheck()
    {
        Debug.Log("Police man completes his check.");
        stateManager.currentState = stateManager.waitForSpeedingCarState;

    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        throw new System.NotImplementedException();
    }

    public void StartCarCheck()
    {
        throw new System.NotImplementedException();
    }
}
