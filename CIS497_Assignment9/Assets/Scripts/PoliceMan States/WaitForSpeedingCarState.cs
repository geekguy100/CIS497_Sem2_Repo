/*****************************************************************************
// File Name :         WaitForSpeedingCarState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class WaitForSpeedingCarState : PoliceManState
{
    public void CompleteCarCheck()
    {
        Debug.Log("We can't complete a check without having started one first!");
    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        Debug.Log("We just spotted a speeding car!  " + car.gameObject.name);
    }

    public void StartCarCheck()
    {
        Debug.Log("No car is available to check.");
    }
}