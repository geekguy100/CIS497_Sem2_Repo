/*****************************************************************************
// File Name :         Entity.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
// CIS497 Assignment 1
// Brief Description : Entity abstract class. Defines basic functionality for all Entities in the game.
*****************************************************************************/
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected string entityName;

    public void setName(string name)
    {
        entityName = name;
    }

    public string getName()
    {
        return entityName;
    }

    public void die()
    {
        Debug.Log(entityName + " has died.");
        Destroy(gameObject);
    }

}