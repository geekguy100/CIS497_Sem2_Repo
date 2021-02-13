/*****************************************************************************
// File Name :         SpawnManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/11/2021
//
// Brief Description : Manages spawning in ball guys.
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [Tooltip("The prefab of the ball guy game object. Color is assigned randomly on instantiation.")]
    [SerializeField] private GameObject ballPrefab;

    [Tooltip("The positions the balls can spawn in.")]
    [SerializeField] private Transform[] spawnPositions;

    [Tooltip("The minimum time to wait before spawning another ball.")]
    [SerializeField] private float minWaitTime = 2f;

    [Tooltip("The maximum time to wait before spawning another ball.")]
    [SerializeField] private float maxWaitTime = 5f;


    private void Start()
    {
        StartCoroutine("Spawn");
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            //Get a random spawn position and spawn a ball there.
            Vector2 spawnPos = spawnPositions[Random.Range(0, spawnPositions.Length)].position;
            Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);

            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
        }
    }
}
