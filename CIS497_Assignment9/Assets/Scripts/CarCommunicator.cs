/*****************************************************************************
// File Name :         CarCommunicator.cs
// Author :            Kyle Grenier
// Creation Date :     04/2/2021
//
// Brief Description : A class that allows other classes to control the behaviour of the car, such as updating its state and properties.
*****************************************************************************/
using UnityEngine;
using System;

[RequireComponent(typeof(CarController))]
[RequireComponent(typeof(CarStateManager))]
public class CarCommunicator : MonoBehaviour
{
    private CarController carController;
    private CarStateManager stateManager;

    private void Awake()
    {
        carController = GetComponent<CarController>();
        stateManager = GetComponent<CarStateManager>();
    }

    public CarState GetCurrentState()
    {
        return stateManager.currentState;
    }

    public float GetSpeed()
    {
        return carController.GetSpeed();
    }

    /// <summary>
    /// Notify the car that it is travelling too fast.
    /// </summary>
    /// <param name="policeOfficer">The police officer waving us down. Used to set the car's destination.</param>
    public void WaveDownCar(GameObject policeOfficer)
    {
        carController.SetDestination(policeOfficer);
        stateManager.TravellingTooFast();
    }

    /// <summary>
    /// Returns true if the car is in the process of pulling over.
    /// </summary>
    /// <returns>True if the car is in the process of pulling over.</returns>
    public bool IsPullingOver()
    {
        return stateManager.currentState == stateManager.gettingPulledOverState;
    }

    /// <summary>
    /// Complete the check of the car.
    /// </summary>
    public void CompleteCarCheck()
    {
        carController.CompleteCheck();
        stateManager.CopDoneInterrogating();
    }
}
