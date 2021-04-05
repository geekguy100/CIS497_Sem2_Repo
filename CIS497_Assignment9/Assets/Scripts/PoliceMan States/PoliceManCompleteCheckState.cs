/*****************************************************************************
// File Name :         PoliceManCompleteCheckState.cs
// Author :            Kyle Grenier
// Creation Date :     04/03/2021
//
// Brief Description : The state that the police man enters after he completes his check.
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
        Debug.Log("Cannot check a car. We just compelted a check.");
        EventManager.PoliceManTalk("Cannot check a car. We just compelted a check.");
    }

    public void CompleteCheck()
    {
        Debug.Log("Police man completes his check.");
        EventManager.PoliceManTalk("Police man completes his check.");
        stateManager.currentState = stateManager.waitForSpeedingCarState;

    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        EventManager.PoliceManTalk("We just completed a check. It's too soon to spot a speeding car.");
        Debug.Log("We just completed a check. It's too soon to spot a speeding car.");
    }

    public void StartCarCheck()
    {
        EventManager.PoliceManTalk("We just completed a check. Cannot start another one so soon.");
        Debug.Log("We just completed a check. Cannot start another one so soon.");
    }
}
