/*****************************************************************************
// File Name :         BlueBlock.cs
// Author :            Kyle Grenier
// Creation Date :     02.05.2021
//
// Brief Description : The blue destroyable block's behaviour.
*****************************************************************************/
using UnityEngine;

public class BlueBlock : DestroyableBlock
{
    protected override void Awake()
    {
        base.Awake();
        ChangeColor(Color.blue);
    }
}
