/*****************************************************************************
// File Name :         CarStateManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class CarStateManager : MonoBehaviour
{
    public CarState travelState { get; private set; }
    public CarState pulledOverState { get; private set; }
    public CarState gettingPulledOverState { get; private set; }

    public CarState currentState { get; set; }

    private void Start()
    {
        travelState = new CarTravelState(this);
        pulledOverState = new CarPulledOverState(this);

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