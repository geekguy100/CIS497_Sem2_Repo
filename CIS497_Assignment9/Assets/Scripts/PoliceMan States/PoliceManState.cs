/*****************************************************************************
// File Name :         PoliceManState.cs
// Author :            Kyle Grenier
// Creation Date :     04/01/2021
//
// Brief Description : Contract for creating a PoliceManState.
*****************************************************************************/

public interface PoliceManState
{
    void SpotSpeedingCar(CarCommunicator car);
    void StartCarCheck();
    void CheckCar();
    void CompleteCheck();
}