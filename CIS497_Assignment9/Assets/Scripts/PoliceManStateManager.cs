/*****************************************************************************
// File Name :         PoliceMan.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class PoliceManStateManager : MonoBehaviour
{
    public PoliceManState WaitForSpeedingCar { get; private set; }
    public PoliceManState WaveDownCar { get; private set; }
    public PoliceManState InvestigateCar { get; private set; }

    private void Start()
    {
        WaitForSpeedingCar = new WaitForSpeedingCarState();
    }
}