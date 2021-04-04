/*****************************************************************************
// File Name :         CarGettingPulledOverState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class CarGettingPulledOverState : CarState
{
    private CarStateManager carStateManager;

    public CarGettingPulledOverState(CarStateManager carStateManager)
    {
        this.carStateManager = carStateManager;
    }

    public void CopDoneInterrogating()
    {
        Debug.Log("We haven't been pulled over yet.");
    }

    public void Move(float speed, GameObject destination)
    {
        Vector3 destinationPos = new Vector3(destination.transform.position.x, carStateManager.transform.position.y, destination.transform.position.z);
        Vector3 dir = (destinationPos - carStateManager.transform.position).normalized;

        //carStateManager.transform.position = Vector3.MoveTowards(carStateManager.transform.position, destinationPos, speed * Time.deltaTime);
        carStateManager.transform.position = destinationPos;

        // If we're near our destination, go to the pulled over state.
        if (Vector3.Distance(carStateManager.transform.position, destinationPos) < 0.05f)
            carStateManager.currentState = carStateManager.pulledOverState;
    }

    public void TravellingTooFast()
    {
        Debug.Log("We're already getting pulled over for going too fast.");
    }
}
