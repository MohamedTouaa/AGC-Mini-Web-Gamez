using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public Vector2 left;
    public Vector2 right;
    public Vector2 top;
    public Vector2 botom;
    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(right);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(left);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(top);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(botom);
        }
    }

    public void UpdateRightX(TMP_InputField text)
    {
        right.x = float.Parse(text.text);
    }
    public void UpdateRightY(TMP_InputField text)
    {
        right.y = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateLeftX(TMP_InputField text)
    {
        left.x = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateLeftY(TMP_InputField text)
    {
        left.y = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateTopX(TMP_InputField text)
    {
        top.x = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateTopY(TMP_InputField text)
    {
        top.y = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateBotomX(TMP_InputField text)
    {
        botom.x = float.Parse(text.text);
        CheckWin();
    }
    public void UpdateBotomY(TMP_InputField text)
    {
        botom.y = float.Parse(text.text);
        CheckWin();
    }


    public void CheckWin()
    {
        if(right == new Vector2(1, 0) && left == new Vector2(-1, 0) && top == new Vector2(0, 1) && botom == new Vector2(0, -1))
        {

        }
    }


   
}
