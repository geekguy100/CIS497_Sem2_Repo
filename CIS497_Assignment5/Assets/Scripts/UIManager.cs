/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Script to manage updating UI.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Tooltip("The text that displays the score.")]
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        PlayerStats.OnScoreChange += UpdateScoreText;
    }

    private void OnDisable()
    {
        PlayerStats.OnScoreChange -= UpdateScoreText;
    }

    private void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
}