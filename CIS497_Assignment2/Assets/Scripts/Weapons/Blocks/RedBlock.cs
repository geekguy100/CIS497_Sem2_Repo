/*****************************************************************************
// File Name :         RedBlock.cs
// Author :            Kyle Grenier
// Creation Date :     02.05.2021
//
// Brief Description : The red destroyable block's behaviour.
*****************************************************************************/
using UnityEngine;

public class RedBlock : DestroyableBlock
{
    protected override void Awake()
    {
        base.Awake();
        ChangeColor(Color.red);
    }
}
