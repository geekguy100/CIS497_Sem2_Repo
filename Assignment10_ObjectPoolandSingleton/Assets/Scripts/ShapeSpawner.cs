/*****************************************************************************
// File Name :         ShapeSpawner.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class ShapeSpawner : MonoBehaviour
{
    private float minX;
    private float maxX;
    private float yPos;

    private void Start()
    {
        Vector2 minCoords = Camera.main.ViewportToWorldPoint(Vector2.zero);
        minX = minCoords.x;
        yPos = minCoords.y - 2f;

        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x;
    }

    public void StartSpawning()
    {
        StartCoroutine(SpawnShape());
    }

    private IEnumerator SpawnShape()
    {
        while (!GameManager.Instance.GameOver)
        {
            float randomTime = Random.Range(0.25f, 2f);
            yield return new WaitForSeconds(randomTime);

            string poolTag = ObjectPooler.Instance.GetRandomTag();
            float randomXPos = Random.Range(minX + 0.5f, maxX - 0.5f);
            ObjectPooler.Instance.SpawnFromPool(poolTag, new Vector2(randomXPos, yPos), Quaternion.identity);
        }
    }
}