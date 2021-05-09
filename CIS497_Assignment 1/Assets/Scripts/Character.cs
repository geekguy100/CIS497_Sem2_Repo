/*****************************************************************************
// File Name :         Character.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private string characterName;
    protected void setName(string name) { characterName = name; }
    protected string getName() { return characterName; }

    private float health;
    protected void setHealth(float h) { health = h; }
    protected float getHealth() { return health; }

    protected Weapon weapon;

    private void Awake()
    {
        weapon = GetComponentInChildren<Weapon>();
        if (weapon != null)
            Debug.Log(characterName + " equips weapon " + weapon.getName());
    }
}