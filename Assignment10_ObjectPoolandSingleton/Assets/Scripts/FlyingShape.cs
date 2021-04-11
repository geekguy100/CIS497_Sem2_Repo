/*****************************************************************************
// File Name :         FlyingShape.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class FlyingShape : MonoBehaviour
{
    private IShapeBehaviour shapeBehaviour;

    [Header("DEBUG")]
    [SerializeField] private int forcedBehaviour;

    private void Start()
    {
        AddRandomBehaviour();
    }

    private void AddRandomBehaviour()
    {
        int num;
        if (forcedBehaviour >= 0)
            num = forcedBehaviour;
        else
            num = Random.Range(0, 4);


        switch(num)
        {
            case 0:
                gameObject.AddComponent<BombBehaviour>();
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}
