/*****************************************************************************
// File Name :         IPooledObject.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public interface IPooledObject
{
    void OnSpawn();
    string GetPoolTag();
}
