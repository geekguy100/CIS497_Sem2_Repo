/*****************************************************************************
// File Name :         InvestigateCarState.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : State the police man enters when he is investigating/checking a car.
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class InvestigateCarState : PoliceManState
{
    private PoliceManStateManager policeManStateManager;
    private bool checkingCar = false;

    public InvestigateCarState(PoliceManStateManager policeManStateManager)
    {
        this.policeManStateManager = policeManStateManager;
    }

    public void CheckCar()
    {
        if (!checkingCar)
        {
            Debug.Log("Police man starts his check...");
            EventManager.PoliceManTalk("Police man starts his check...");
            policeManStateManager.StartCoroutine(PerformCheck());
        }
    }

    public void CompleteCheck()
    {
        Debug.Log("We are still investigating the car.");
        EventManager.PoliceManTalk("We are still investigating the car.");
    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        Debug.Log("No need to spot another car -- we're already investigating one.");
        EventManager.PoliceManTalk("No need to spot another car -- we're already investigating one.");
    }

    public void StartCarCheck()
    {
        Debug.Log("No need to start the check since we're already checking a car.");
        EventManager.PoliceManTalk("No need to start the check since we're already checking a car.");
    }

    private IEnumerator PerformCheck()
    {
        checkingCar = true;
        yield return new WaitForSeconds(5f);
        policeManStateManager.currentState = policeManStateManager.completeInvestigation;
        checkingCar = false;
    }
}