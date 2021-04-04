/*****************************************************************************
// File Name :         PoliceManController.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(PoliceManStateManager))]
public class PoliceManController : MonoBehaviour
{
    private PoliceManStateManager policeManStateManager;
    private CarCommunicator nearbyCar = null;

    [SerializeField] private float speedLimit = 5f;

    private void Awake()
    {
        policeManStateManager = GetComponent<PoliceManStateManager>();
    }

    private void Update()
    {
        if (nearbyCar != null && policeManStateManager.currentState == policeManStateManager.waitForSpeedingCarState)
        {
            float carSpeed = nearbyCar.GetSpeed();
            if (carSpeed > speedLimit)
            {
                nearbyCar.WaveDownCar(gameObject);
                policeManStateManager.SpotSpeedingCar(nearbyCar);
            }
        }
        else if (policeManStateManager.currentState == policeManStateManager.waveDownCar)
        {
            // Once the car is done pulling over, start checking it.
            if (!nearbyCar.IsPullingOver())
                policeManStateManager.StartCarCheck();
        }
        else if (policeManStateManager.currentState == policeManStateManager.investigateCarState)
        {
            policeManStateManager.CheckCar();
        }
        else if (policeManStateManager.currentState == policeManStateManager.completeInvestigation)
        {
            nearbyCar = null;
            policeManStateManager.CompleteCheck();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            nearbyCar = other.GetComponent<CarCommunicator>();
            print(nearbyCar.gameObject.name);
        }
    }
}