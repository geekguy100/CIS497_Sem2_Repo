/*****************************************************************************
// File Name :         BallSpawner.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] balls;

    private void OnEnable()
    {
        EventManager.OnBallDestroyed += SpawnBall;
    }

    private void OnDisable()
    {
        EventManager.OnBallDestroyed -= SpawnBall;
    }

    private void SpawnBall()
    {
        GameObject ball = ArrayHelper.GetRandomElement(balls);
        Instantiate(ball, transform.position, ball.transform.rotation);
    }
}
