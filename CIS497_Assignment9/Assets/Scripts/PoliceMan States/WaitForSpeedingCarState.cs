/*****************************************************************************
// File Name :         WaitForSpeedingCarState.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : State the police man enters when he is waiting for a speeding car to pass by.
*****************************************************************************/
using UnityEngine;

public class WaitForSpeedingCarState : PoliceManState
{
    private PoliceManStateManager policeManStateManager;

    public WaitForSpeedingCarState(PoliceManStateManager policeManStateManager)
    {
        this.policeManStateManager = policeManStateManager;
    }

    public void CheckCar()
    {
        Debug.Log("We can't check a car without having spotted one first!");
    }

    public void CompleteCheck()
    {
        Debug.Log("Cannot complete the check without having started one");
    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        Debug.Log("We just spotted a speeding car!  " + car.gameObject.name);
        policeManStateManager.currentState = policeManStateManager.waveDownCar;
    }

    public void StartCarCheck()
    {
        Debug.Log("No car is available to check.");
    }
}