/*****************************************************************************
// File Name :         CarState.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public interface CarState
{
    void TravellingTooFast();
    void CopDoneInterrogating();
    void Move(float speed, GameObject destination = null);
}
