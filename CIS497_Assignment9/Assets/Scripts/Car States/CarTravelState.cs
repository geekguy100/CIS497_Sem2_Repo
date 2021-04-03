/*****************************************************************************
// File Name :         CarTravelState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class CarTravelState : CarState
{
    private CarStateManager car;

    public CarTravelState(CarStateManager car)
    {
        this.car = car;
    }

    public void CopDoneInterrogating()
    {
        Debug.Log("No cop interrogating! We're safe!");
    }

    public void Move(float speed, GameObject destination = null)
    {
        car.transform.localPosition += car.transform.forward * speed * Time.deltaTime;
    }

    public void TravellingTooFast()
    {
        Debug.Log("Uh oh! We're going too fast!");
        car.currentState = car.pulledOverState;
    }
}
