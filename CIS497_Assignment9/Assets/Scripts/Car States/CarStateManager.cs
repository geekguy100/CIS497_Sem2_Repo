/*****************************************************************************
// File Name :         CarStateManager.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : Class to interface with the states of a car.
*****************************************************************************/
using UnityEngine;

public class CarStateManager : MonoBehaviour
{
    public CarState travelState { get; private set; }
    public CarState pulledOverState { get; private set; }
    public CarState gettingPulledOverState { get; private set; }

    private CarState _currentState;
    public CarState currentState
    {
        get { return _currentState; }
        set
        {
            _currentState = value;
        }
    }



    private void Start()
    {
        travelState = new CarTravelState(this);
        pulledOverState = new CarPulledOverState(this);
        gettingPulledOverState = new CarGettingPulledOverState(this);

        currentState = travelState;
    }

    public void TravellingTooFast()
    {
        currentState.TravellingTooFast();
    }

    public void CopDoneInterrogating()
    {
        currentState.CopDoneInterrogating();
    }

    public void Move(float speed, GameObject destination = null)
    {
        currentState.Move(speed, destination);
    }
}