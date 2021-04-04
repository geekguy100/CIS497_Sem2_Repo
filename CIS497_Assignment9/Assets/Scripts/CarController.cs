/*****************************************************************************
// File Name :         CarController.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CarStateManager))]
public class CarController : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float cruisingSpeed;
    [SerializeField] private float accelerationTime = 2f;
    private float currentSpeed;
    private GameObject destination;

    public CarStateManager stateManager { get; private set; }

    // Are we accelerating or decelerating?
    private bool modifyingSpeed = false;


    // Last call to a modify speed coroutine.
    private Coroutine modifySpeedCall;




    private void Awake()
    {
        stateManager = GetComponent<CarStateManager>();
    }

    void Start()
    {
        currentSpeed = cruisingSpeed;
    }

    private void Update()
    {
        if (stateManager.currentState == stateManager.travelState)
        {
            stateManager.Move(currentSpeed);

            if (Input.GetKeyDown(KeyCode.Space) && !modifyingSpeed)
                modifySpeedCall = Accelerate();
        }
        else if (stateManager.currentState == stateManager.gettingPulledOverState)
        {
            // Decelerate and move towards the cop car.
            if (currentSpeed > cruisingSpeed)
            {
                if (modifySpeedCall != null)
                    StopCoroutine(modifySpeedCall);

                modifySpeedCall = Decelerate();
            }

            stateManager.Move(currentSpeed, destination);
        }
    }

    public void SetDestination(GameObject destination)
    {
        this.destination = destination;
    }

    public float GetSpeed()
    {
        return currentSpeed;
    }



    private Coroutine Accelerate()
    {
        return StartCoroutine(ChangeSpeedOverTime(maxSpeed, accelerationTime));
    }

    private Coroutine Decelerate()
    {
        return StartCoroutine(ChangeSpeedOverTime(cruisingSpeed, accelerationTime));
    }

    private IEnumerator ChangeSpeedOverTime(float finalSpeed, float time)
    {
        modifyingSpeed = true;
        float cSpeed = currentSpeed;
        float counter = 0;

        while (currentSpeed < maxSpeed)
        {
            counter += Time.deltaTime;
            currentSpeed = Mathf.Lerp(cSpeed, finalSpeed, counter / time);
            yield return null;
        }

        currentSpeed = finalSpeed;
        modifyingSpeed = false;
    }
}