/*****************************************************************************
// File Name :         SoundBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Controls playing sounds for characters.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CharacterSoundController : MonoBehaviour
{
    [Tooltip("The audio clips that can be played.")]
    [SerializeField] private AudioClip[] clips;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Play a one-shot of the clip at the given index.
    /// </summary>
    /// <param name="index">The index of the audio clip.</param>
    public void Play(int index)
    {
        audioSource.PlayOneShot(clips[index]);
    }
}
