/*****************************************************************************
// File Name :         PoliceManController.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : Script that controls the behavior of the police man.
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
        if (nearbyCar == null)
            return;

        if (policeManStateManager.currentState == policeManStateManager.waitForSpeedingCarState)
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
            policeManStateManager.CompleteCheck();
            nearbyCar.CompleteCarCheck();
            nearbyCar = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            nearbyCar = other.GetComponent<CarCommunicator>();
        }
    }
}