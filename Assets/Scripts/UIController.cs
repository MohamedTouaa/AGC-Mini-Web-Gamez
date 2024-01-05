using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

[System.Serializable]
public class SceneButton
{
    public Button button;
    public string sceneToLoad;
    public DateTime unlockDate;
}

public class UIController : MonoBehaviour
{
    public GameObject uiPanel;
    public SceneButton[] sceneButtons;

    void Start()
    {
        // Check unlock dates for each scene button
        foreach (var buttonInfo in sceneButtons)
        {
            // Check if the current date is after the unlock date
            if (DateTime.Now >= buttonInfo.unlockDate)
            {
                // Unlock the button
                buttonInfo.button.interactable = true;
            }
            else
            {
                // Lock the button
                buttonInfo.button.interactable = false;
            }
        }
    }

    // Public method to be called when the button is clicked to toggle the panel
    public void ToggleUI()
    {
        uiPanel.SetActive(!uiPanel.activeSelf);
    }

    // Public method to be called when the close button is clicked
    public void CloseUI()
    {
        uiPanel.SetActive(false);
    }

    // Public method to be called when a scene load button is clicked
    public void LoadScene(int buttonIndex)
    {
        var buttonInfo = sceneButtons[buttonIndex];

        if (buttonInfo.button.interactable)
        {
            SceneManager.LoadScene(buttonInfo.sceneToLoad);
        }
        else
        {
            Debug.Log($"Button {buttonIndex + 1} is locked. Cannot load scene.");
            // Optionally, you can provide some feedback to the user when the button is locked.
        }
    }
}
