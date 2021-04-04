/*****************************************************************************
// File Name :         PoliceMan.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class PoliceManStateManager : MonoBehaviour, PoliceManState
{
    public PoliceManState waitForSpeedingCarState { get; private set; }
    public PoliceManState waveDownCar { get; private set; }
    public PoliceManState investigateCarState { get; private set; }
    public PoliceManState completeInvestigation { get; private set; }

    public PoliceManState currentState { get; set; }

    private void Start()
    {
        waitForSpeedingCarState = new WaitForSpeedingCarState(this);
        waveDownCar = new WaveDownCarState(this);
        investigateCarState = new InvestigateCarState(this);
        completeInvestigation = new PoliceManCompleteCheckState(this);

        currentState = waitForSpeedingCarState;
    }

    public void CheckCar()
    {
        currentState.CheckCar();
    }

    public void SpotSpeedingCar(CarCommunicator car)
    {
        currentState.SpotSpeedingCar(car);
    }

    public void StartCarCheck()
    {
        currentState.StartCarCheck();
    }

    public void CompleteCheck()
    {
        currentState.CompleteCheck();
    }
}