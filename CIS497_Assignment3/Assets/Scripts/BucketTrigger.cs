/*****************************************************************************
// File Name :         BucketTrigger.cs
// Author :            Kyle Grenier
// Creation Date :     02/11/2021
//
// Brief Description : Controls what occurs when a Collider2D enters the trigger.
*****************************************************************************/
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    private bool gameOver = false;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        EventManager.OnGameLost += GameOver;
        EventManager.OnGameWin += GameOver;
    }

    private void OnDisable()
    {
        EventManager.OnGameLost -= GameOver;
        EventManager.OnGameWin -= GameOver;
    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.transform.parent.gameObject);

        if(!gameOver)
        {
            EventManager.BucketTrigger();
            audioSource.Play();
        }
    }

    private void GameOver()
    {
        gameOver = true;
    }
}
