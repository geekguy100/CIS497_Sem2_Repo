/*****************************************************************************
// File Name :         SpawnManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/05/2021
//
// Brief Description : Manages spawning in the block prefabs.
*****************************************************************************/
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] blockPrefabs = null;
    [SerializeField] private Transform[] spawnPos = null; //Only using the first two.

    private void Start()
    {
        //Spawn a pair of blocks every 5 seconds.
        InvokeRepeating("Spawn", 0f, 5f);
    }

    /// <summary>
    /// Spawns two random block prefabs at the two spawn positions.
    /// </summary>
    void Spawn()
    {
        int blockIndex = Random.Range(0, blockPrefabs.Length);

        Instantiate(blockPrefabs[blockIndex], spawnPos[0].position, blockPrefabs[blockIndex].transform.rotation);

        blockIndex = Random.Range(0, blockPrefabs.Length);

        Instantiate(blockPrefabs[blockIndex], spawnPos[1].position, blockPrefabs[blockIndex].transform.rotation);
    }
}
