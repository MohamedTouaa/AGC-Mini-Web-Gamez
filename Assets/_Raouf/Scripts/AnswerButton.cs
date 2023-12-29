using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public string answer;
    public bool correct;
    public TextMeshProUGUI text;
    public Image answerBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckCorrectAnswer()
    {
        if (correct)
        {
            StartCoroutine(ChangeColor(Color.green));
            QuizManager.instance.LoadNewQuestion();
            QuizManager.instance.UpadteScore(1);
        }
        else
        {
            StartCoroutine(ChangeColor(Color.red));
            QuizManager.instance.LoadNewQuestion();
        }
    }
    IEnumerator ChangeColor(Color color)
    {
        yield return new WaitForSeconds(1f);
        answerBackground.color = color;
    }
}
