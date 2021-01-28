/*****************************************************************************
// File Name :         IMoveable.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public interface IMoveable
{
    void moveTowards(Entity target);
    void moveTowards(Vector3 destination);
}