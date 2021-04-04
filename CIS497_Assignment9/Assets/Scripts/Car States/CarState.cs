/*****************************************************************************
// File Name :         CarState.cs
// Author :            Kyle Grenier
// Creation Date :     04/02/2021
//
// Brief Description : Contract for creating a CarState.
*****************************************************************************/
using UnityEngine;

public interface CarState
{
    void TravellingTooFast();
    void CopDoneInterrogating();
    void Move(float speed, GameObject destination = null);
}
