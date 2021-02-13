/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/12/2021
//
// Brief Description : Manager script to handle changes to game state.
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    private string currentLevelName = string.Empty;

    List<AsyncOperation> loadOperations;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        loadOperations = new List<AsyncOperation>();

        //TODO: Load "Main" level.
    }


    private void OnLoadOperationComplete(AsyncOperation ao)
    {
        if(loadOperations.Contains(ao))
        {
            loadOperations.Remove(ao);

            
        }

        Debug.Log("Load complete.");
    }

    private void OnUnloadOperationComplete(AsyncOperation ao)
    {
        Debug.Log("Unload complete.");
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogWarning("GameManager: Unable to load level " + levelName);
            return;
        }

        ao.completed += OnLoadOperationComplete;
        loadOperations.Add(ao);
        currentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogWarning("GameManager: Unable to unload level " + levelName);
            return;
        }
        
        ao.completed += OnUnloadOperationComplete;
    }
}
