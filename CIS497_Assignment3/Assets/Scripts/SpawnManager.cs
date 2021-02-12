/*****************************************************************************
// File Name :         SpawnManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Manages spawning in ball guys.
*****************************************************************************/
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Tooltip("The prefab of the ball guy game object. Color is assigned randomly on instantiation.")]
    [SerializeField] private GameObject ballPrefab;
}
