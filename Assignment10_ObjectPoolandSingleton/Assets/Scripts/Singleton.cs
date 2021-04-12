/*****************************************************************************
// File Name :         Singleton.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance { get { return instance; } }

    protected virtual void Awake()
    {
        if (instance == null)
            instance = this as T;
        else
            Destroy(gameObject);
    }

    protected virtual void OnDestroy()
    {
        //if this object is destroyed, make instance null so another can be created
        if (instance == this)
        {
            instance = null;
        }
    }
}
