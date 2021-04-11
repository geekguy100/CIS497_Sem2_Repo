/*****************************************************************************
// File Name :         ShapeBehaviourManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public static class ShapeBehaviourManager
{
    private static System.Type[] shapeBehaviours;


    static ShapeBehaviourManager()
    {
        Debug.Log("HIT");
        IShapeBehaviour[] objs = Resources.LoadAll("Shape Behaviours") as IShapeBehaviour[];
        foreach (IShapeBehaviour o in objs)
            Debug.Log(o);
    }

    public static void GetRandomBehaviour()
    {
        //int index = Random.Range(0, shapeBehaviours.Length);
        //return shapeBehaviours[index];
    }
}
