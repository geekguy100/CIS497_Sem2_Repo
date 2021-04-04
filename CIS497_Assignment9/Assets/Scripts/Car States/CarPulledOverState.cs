/*****************************************************************************
// File Name :         CarPulledOverState.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : State the car enters when it is pulled over.
*****************************************************************************/
using UnityEngine;

public class CarPulledOverState : CarState
{
    private CarStateManager carStateManager;

    public CarPulledOverState(CarStateManager car)
    {
        carStateManager = car;
    }

    public void CopDoneInterrogating()
    {
        Debug.Log("Cop is all done.");
        carStateManager.currentState = carStateManager.travelState;
    }

    public void Move(float speed, GameObject destination = null)
    {
        Debug.Log("Best not to move when we're being interrogated...");
    }

    public void TravellingTooFast()
    {
        Debug.Log("We're pulled over and not moving.");
    }
}
