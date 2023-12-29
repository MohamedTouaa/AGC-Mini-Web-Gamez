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
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckCorrectAnswer()
    {
        QuizManager.instance.DisableButtons();
        if (correct)
        {

            StartCoroutine(ChangeColor(Color.green, QuizManager.instance.right));

            QuizManager.instance.UpadteScore(1);
        }
        else
        {
            StartCoroutine(ChangeColor(Color.red, QuizManager.instance.Wrong));
        }
    }
    IEnumerator ChangeColor(Color color, AudioClip clip)
    {
        yield return new WaitForSeconds(1f);
        source.PlayOneShot(clip, 1f);
        answerBackground.color = color;
        QuizManager.instance.LoadNewQuestion();
       
    }
}
