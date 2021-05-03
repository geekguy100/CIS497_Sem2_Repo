/*****************************************************************************
// File Name :         PowerUpManager.cs
// Author :            Kyle Grenier
// Creation Date :     05/03/2021
//
// Brief Description : Manages adding, removing, and activating powerups from a character.
*****************************************************************************/
using UnityEngine;
using System.Collections.Generic;

public class PowerUpManager : MonoBehaviour
{
    private PowerUpContainer container;

    private void Awake()
    {
        container = new PowerUpContainer();
    }

    private void Update()
    {
        // If we're holding left shift, remove the component.
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                container.Remove<HealthPowerUp>();
            else if (Input.GetKeyDown(KeyCode.Alpha2))
                container.Add(new ManaPowerUp(29));
            else if (Input.GetKeyDown(KeyCode.Alpha3))
                container.Add(new StrengthPowerUp(12));
            else if (Input.GetKeyDown(KeyCode.Alpha4))
                container.Add(new AllStatIncrease(90, 90, 90));
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                container.Add(new HealthPowerUp(10));
            else if (Input.GetKeyDown(KeyCode.Alpha2))
                container.Add(new ManaPowerUp(29));
            else if (Input.GetKeyDown(KeyCode.Alpha3))
                container.Add(new StrengthPowerUp(12));
            else if (Input.GetKeyDown(KeyCode.Alpha4))
                container.Add(new AllStatIncrease(90, 90, 90));
        }


        if (Input.GetKeyDown(KeyCode.Space))
            container.Activate(GetComponent<Character>());
    }
}