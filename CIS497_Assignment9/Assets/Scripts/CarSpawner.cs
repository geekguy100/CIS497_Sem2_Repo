/*****************************************************************************
// File Name :         CarSpawner.cs
// Author :            Kyle Grenier
// Creation Date :     04/04/2021
//
// Brief Description : Handles spawning in cars.
*****************************************************************************/
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject carPrefab;

    private void OnEnable()
    {
        EventManager.OnCarDespawn += SpawnCar;
    }

    private void OnDisable()
    {
        EventManager.OnCarDespawn -= SpawnCar;
    }

    void SpawnCar()
    {
        CarCommunicator carCommunicator = Instantiate(carPrefab).GetComponent<CarCommunicator>();
        EventManager.CarSpawn(carCommunicator);
    }
}
