/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script that manages updating UI.
*****************************************************************************/
using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI tutorialText;

    [Tooltip("The Animator used to control the title screen animations.")]
    [SerializeField] private Animator titleAnimator;

    [Tooltip("The Animator used to control the score sliding animation.")]
    [SerializeField] private Animator scoreAnim;

    [Tooltip("The Animator used to control the lives sliding animation.")]
    [SerializeField] private Animator livesAnim;

    [Tooltip("The Animator used to control the UI animations after the game ends.")]
    [SerializeField] private Animator gameEndAnim;

    private void Awake()
    {
        EventManager.OnScoreChange += UpdateScoreText;
        EventManager.OnLoseLife += UpdateLivesText;
        EventManager.OnTutorialStart += FadeOutTitle;
        EventManager.OnGameStart += FadeOutTutorial;
        EventManager.OnGameLost += OnGameLost;
        EventManager.OnGameWin += OnGameWin;
    }

    private void OnDisable()
    {
        EventManager.OnScoreChange -= UpdateScoreText;
        EventManager.OnLoseLife -= UpdateLivesText;
        EventManager.OnTutorialStart -= FadeOutTitle;
        EventManager.OnGameStart -= FadeOutTutorial;
        EventManager.OnGameLost -= OnGameLost;
        EventManager.OnGameWin -= OnGameWin;
    }

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        int score = scoreManager.WinningScore;

        PlayerLives playerLives = FindObjectOfType<PlayerLives>();
        int lives = playerLives.Lives;

        livesText.text = lives.ToString();

        tutorialText.text =
            "GOAL:  Corral the Puffles into the bucket.\n\n" +
            "Hold <LEFT MOUSE> and drag to push the Puffles around the play area.\n\n" +
            "Be warned, if <" + lives + "> escape, you'll lose!\n\n" +
            "Your goal is to get <" + score + "> into the bucket.\n\n" +
            "Press <ENTER> to begin...";
    }

    /// <summary>
    /// Updates the score text and plays the animation to display the score.
    /// </summary>
    /// <param name="score">The score the player has.</param>
    private void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();

        //Only run if the animation is in an idle state.
        if (scoreAnim != null && scoreAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "score_idle")
        {
            scoreAnim.SetTrigger("Score Changed");
        }
    }

    /// <summary>
    /// Updates the lives text and plays the animation to display lives.
    /// </summary>
    /// <param name="lives">Number of lives the player has.</param>
    private void UpdateLivesText(int lives)
    {
        livesText.text = lives.ToString();

        //Only run if the animation is in an idle state.
        if (livesAnim != null && livesAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "lives_idle")
        {
            livesAnim.SetTrigger("Lives Changed");
        }
    }

    private void OnGameLost()
    {
        gameEndAnim.SetTrigger("Game Lost");
    }

    private void OnGameWin()
    {
        gameEndAnim.SetTrigger("Game Won");
    }

    /// <summary>
    /// Fades out the title text and "press enter to start" text.
    /// </summary>
    private void FadeOutTitle()
    {
        titleAnimator.SetTrigger("Fade Out Title");
    }

    /// <summary>
    /// Fades out the tutorial text.
    /// </summary>
    private void FadeOutTutorial()
    {
        titleAnimator.SetTrigger("Fade Out Tutorial");
    }
}
