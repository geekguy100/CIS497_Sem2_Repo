/*****************************************************************************
// File Name :         BallSpawner.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Spawns in a random sports ball when one is needed.
*****************************************************************************/
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] balls;

    private bool applicationQuitting = false;

    private void OnEnable()
    {
        EventManager.OnBallDestroyed += SpawnBall;
        Application.quitting += () => { applicationQuitting = true; };
    }

    private void OnDisable()
    {
        EventManager.OnBallDestroyed -= SpawnBall;
    }

    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        if (GameManager.instance.GameOver || applicationQuitting)
            return;

        GameObject ball = ArrayHelper.GetRandomElement(balls);
        Instantiate(ball, transform.position, ball.transform.rotation);
    }
}
