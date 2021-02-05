/*****************************************************************************
// File Name :         Timer.cs
// Author :            Kyle Grenier
// Creation Date :     02/04/2021
//
// Brief Description : Timer class that counts down. Next question on timer finish.
*****************************************************************************/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float maxTime;

    [SerializeField] private Image timerImg;

    public delegate void TimerEndHandler();
    public event TimerEndHandler OnTimerEnd;

    private void Awake()
    {
        timerImg.fillAmount = 1;
    }

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    public void SetTime(float time)
    {
        maxTime = time;
    }

    private IEnumerator Countdown()
    {
        float time = maxTime;

        while (time > 0f)
        {
            time -= Time.deltaTime / maxTime;
            timerImg.fillAmount -= Time.deltaTime / maxTime;

            yield return null;
        }

        OnTimerEnd?.Invoke();
    }
}