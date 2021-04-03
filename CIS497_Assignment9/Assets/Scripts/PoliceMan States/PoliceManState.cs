/*****************************************************************************
// File Name :         PoliceManState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/

public interface PoliceManState
{
    void SpotSpeedingCar(CarCommunicator car);
    void StartCarCheck();
    void CompleteCarCheck();
}