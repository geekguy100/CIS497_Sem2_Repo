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
    [Tooltip("Number of seconds between pairs of blocks spawning.")]
    [SerializeField] private float spawnTime = 5f;

    [Tooltip("Number of seconds until blocks start spawning.")]
    [SerializeField] private float initialDelay = 5f;

    [Tooltip("Prefab of blocks to spawn. ONLY USING THE FIRST TWO.")]
    [SerializeField] private GameObject[] blockPrefabs = null;
    [SerializeField] private Transform[] spawnPos = null; //Only using the first two.

    private GameManager gm;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        gm.OnGameOver += CancelSpawning;
        gm.OnGameWin += CancelSpawning;
    }

    private void OnDisable()
    {
        gm.OnGameOver -= CancelSpawning;
        gm.OnGameWin -= CancelSpawning;
    }

    private void Start()
    {
        //Spawn a pair of blocks every 5 seconds.
        InvokeRepeating("Spawn", initialDelay, spawnTime);
    }

    /// <summary>
    /// Spawns two random block prefabs at the two spawn positions.
    /// </summary>
    void Spawn()
    {
        int blockIndex = Random.Range(0, blockPrefabs.Length);

        GameObject spawnOne = Instantiate(blockPrefabs[blockIndex], spawnPos[0].position, blockPrefabs[blockIndex].transform.rotation);

        blockIndex = Random.Range(0, blockPrefabs.Length);

        GameObject spawnTwo = Instantiate(blockPrefabs[blockIndex], spawnPos[1].position, blockPrefabs[blockIndex].transform.rotation);
    }

    /// <summary>
    /// Stops the blocks from spawning.
    /// </summary>
    private void CancelSpawning()
    {
        CancelInvoke("Spawn");
    }
}
