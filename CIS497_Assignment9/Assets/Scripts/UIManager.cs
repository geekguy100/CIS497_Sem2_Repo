/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     04/04/2021
//
// Brief Description : Handles updating UI elements.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI stateText;
    [SerializeField] private TextMeshProUGUI outputText;

    private void OnEnable()
    {
        EventManager.OnPoliceManTalk += SetPoliceManOutputText;
        EventManager.OnPoliceManStateChange += SetPoliceManStateText;
    }

    private void OnDisable()
    {
        EventManager.OnPoliceManTalk -= SetPoliceManOutputText;
        EventManager.OnPoliceManStateChange -= SetPoliceManStateText;
    }

    public void SetPoliceManStateText(PoliceManState state)
    {
        stateText.text = "State:\n" + state;
    }

    public void SetPoliceManOutputText(string text)
    {
        outputText.text = "Output:\n" + text;
    }
}
