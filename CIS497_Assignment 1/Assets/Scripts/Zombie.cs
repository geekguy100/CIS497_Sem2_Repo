/*****************************************************************************
// File Name :         Zombie.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/21
//
// Brief Description : Zombie enemy. Moves towards and damages player.
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class Zombie : Entity, IDamageable, IMoveable, ICanAttack
{
    private float movementSpeed;
    private float health;

    private GameObject player;
    private bool tracking;

    private float attackSpeed = 2f;
    private float currentAttackTime = 0f;

    private void Awake()
    {
        setName("Zombie");
        movementSpeed = 5f;
        health = 100f;
        tracking = false;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null)
            return;

        //Managing delay between attacks.
        if (currentAttackTime < attackSpeed)
            currentAttackTime += Time.deltaTime;

        //If Zombie is out of range of player, move towards it.
        if (Vector3.Distance(transform.position, player.transform.position) > 1f && !tracking)
        {
            tracking = true;
            StartCoroutine(moveTowards(player.transform.position));
        }
        //If we are not tracking (in range of player), attack him.
        else if (!tracking)
        {
            //Attack after delay.
            if (currentAttackTime >= attackSpeed)
            {
                attack(player.GetComponent<IDamageable>(), 10f);
                currentAttackTime = 0f;
            }
        }
    }


    public void attack(IDamageable target, float damageDealt)
    {
        Debug.Log(entityName + " attacks for " + damageDealt + " damage.");
        target.takeDamage(damageDealt);
    }

    public IEnumerator moveTowards(Vector3 destination)
    {   
        while (Vector3.Distance(transform.position, destination) > 1f)
        {
            destination = player.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, destination, movementSpeed * Time.deltaTime);
            yield return null;
        }

        //Stop tracking now that Zombie is at target position.
        tracking = false;
    }

    public void takeDamage(float amnt)
    {
        health -= amnt;
        if (health < 0)
            die();
    }
}