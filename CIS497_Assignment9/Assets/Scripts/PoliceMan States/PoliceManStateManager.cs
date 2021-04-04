/*****************************************************************************
// File Name :         PoliceManStateManager.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : A class to interface with the states of the police man.
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