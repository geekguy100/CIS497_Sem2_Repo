/*****************************************************************************
// File Name :         Scoreboard.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : A scoreboard that updates based on the player's score and in-game actions.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI ballText;
    [SerializeField] private TextMeshProUGUI forceText;

    #region --- Event Stuff ---
    private void OnEnable()
    {
        EventManager.OnKickOff += UpdateKickData;
        EventManager.OnTargetHit += UpdateScore;
    }

    private void OnDisable()
    {
        EventManager.OnKickOff -= UpdateKickData;
        EventManager.OnTargetHit -= UpdateScore;
    }

    #endregion

    private void UpdateKickData(KickData data)
    {
        ballText.text = "BALL: " + data.BallName.ToUpper();
        forceText.text = "FORCE: " + System.Math.Round(data.KickForce.magnitude, 2);
    }

    private void UpdateScore()
    {
        scoreText.text = "SCORE: " + ScoreManager.Score;
    }
}