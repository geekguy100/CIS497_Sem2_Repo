/*****************************************************************************
// File Name :         Player.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
// CIS497 Assignment 1
// Brief Description : Player functionality
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class Player : Entity, IDamageable, IMoveable, ICanAttack
{
    private float movementSpeed;
    public float health { get; set; }

    private IDamageable enemy;

    private void Awake()
    {
        setName("Player");
        movementSpeed = 7f;
        health = 100f;

        enemy = GameObject.FindGameObjectWithTag("Zombie").GetComponent<IDamageable>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit);
            Vector3 pos = hit.point;
            pos.y = transform.position.y;

            StopAllCoroutines();
            StartCoroutine(moveTowards(pos));

            //If you click on a damageable, attack it.
            if (hit.transform != null && hit.transform.GetComponent<IDamageable>() != null && Vector3.Distance(transform.position, hit.point) < 2f)
            {
                attack(hit.transform.GetComponent<IDamageable>(), 20f);
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
            transform.position = Vector3.MoveTowards(transform.position, destination, movementSpeed * Time.deltaTime);
            yield return null;
        }
    }

    public void takeDamage(float amnt)
    {
        health -= amnt;
        if (health < 0)
            die();
    }
}