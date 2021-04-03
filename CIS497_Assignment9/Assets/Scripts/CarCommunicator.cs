/*****************************************************************************
// File Name :         CarCommunicator.cs
// Author :            Kyle Grenier
// Creation Date :     04/2/2021
//
// Brief Description : A class that allows other classes to control the behaviour of the car, such as updating its state and properties.
*****************************************************************************/
using UnityEngine;

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
    /// Complete the check of the car.
    /// </summary>
    public void CompleteCarCheck()
    {
        stateManager.CopDoneInterrogating();
    }
}
