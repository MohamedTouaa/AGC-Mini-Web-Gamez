using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public GameObject uiPanel;

    
    public void OnCloseButtonClick()
    {
        if (uiPanel != null)
        {
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI Panel reference is not set in CloseButton script.");
        }
    }
}
