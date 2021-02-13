/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script that manages updating UI.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI startText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Animator titleAnimator;

    [Tooltip("The Animator used to control the score sliding animation.")]
    [SerializeField] private Animator scoreAnim;

    private void Awake()
    {
        EventManager.OnScoreChange += UpdateScoreText;
        EventManager.OnGameStart += FadeOutTitle;
    }

    private void OnDisable()
    {
        EventManager.OnScoreChange -= UpdateScoreText;
        EventManager.OnGameStart -= FadeOutTitle;
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();

        //Only run if the animation is in an idle state.
        if (scoreAnim != null && scoreAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "score_idle")
        {
            scoreAnim.SetTrigger("Score Changed");
        }
    }

    /// <summary>
    /// Fades out the title text and "press enter to start" text.
    /// </summary>
    public void FadeOutTitle()
    {
        titleAnimator.SetTrigger("Fade Out");
    }
}
