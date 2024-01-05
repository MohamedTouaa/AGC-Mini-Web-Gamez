using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameManager : MonoBehaviour
{
    public Sprite playImage;
    public PlayerMovement2 player;
    bool onPlayMode = false;
    public Image playModebtn;
    // Start is called before the first frame update
    void Start()
    {
        
        QuitPlayMode();
    }


    public void TogglePlayMode()
    {
        if(onPlayMode)
        {
            QuitPlayMode();
        }

        else
        {
            EnterPlayMode();
        }
    }

    public void EnterPlayMode()
    {
        onPlayMode = true;
        player.enabled = true;
        playModebtn.sprite = playImage;
        SetImageAlpha(255);
    }

    public void QuitPlayMode()
    {
        onPlayMode = false;
        player.enabled = false;
        SetImageAlpha(0);
    }
    void SetImageAlpha(float alpha)
    {       
        // Get the current color of the image
        Color imageColor = playModebtn.color;

        // Set the alpha component to the specified value
        imageColor.a = alpha;

        // Apply the modified color back to the image
        playModebtn.color = imageColor;
    }
}
