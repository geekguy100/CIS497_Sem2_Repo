/*****************************************************************************
// File Name :         PlayerLives.cs
// Author :            Kyle Grenier
// Creation Date :     02/14/2021
//
// Brief Description : Script to control player lives; how many puffles they can lose before the game is over.
*****************************************************************************/
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    public int Lives { get { return lives;} }
    private bool canTakeLives = true;

    private void Awake()
    {
        EventManager.OnPuffleLost += TakeDamage;
    }

    private void OnDisable()
    {
        EventManager.OnPuffleLost -= TakeDamage;
    }

    public void TakeDamage(int damage)
    {
        //Only take lives if the game is NOT over.
        if (!canTakeLives)
            return;
        lives -= damage;
        EventManager.LoseLife(lives);

        if (lives <= 0)
        {
            EventManager.GameLost();
            canTakeLives = false;
        }
    }
}
