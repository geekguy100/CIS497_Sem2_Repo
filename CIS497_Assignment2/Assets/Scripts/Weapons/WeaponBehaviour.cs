/*****************************************************************************
// File Name :         WeaponBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines the requirements for creating a new WeaponBehaviour.
*****************************************************************************/
using UnityEngine;

public abstract class WeaponBehaviour : MonoBehaviour
{
    //Change color on Awake, so when the WeaponBehaviour is swapped in.
    protected virtual void Awake()
    {
        ChangeColor();
    }

    public abstract void Fire();
    protected abstract void ChangeColor();
}
