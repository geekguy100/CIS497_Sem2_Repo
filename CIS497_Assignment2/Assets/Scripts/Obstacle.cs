/*****************************************************************************
// File Name :         Obstacle.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Controls behaviour for obstacles - game objects which translate across the screen towards the player.
*****************************************************************************/
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    [Header("Obstacle Fields")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float destroyTime = 15f;

    protected virtual void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    protected virtual void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
