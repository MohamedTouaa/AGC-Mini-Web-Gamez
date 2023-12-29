using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public static QuizManager instance;
    public GameObject answerPrefab;
    public Transform answersParent;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI scoreText;
    public Questions questions;
    public int questionNum;
    public int score;


    public GameObject quiz;
    public GameObject endMenu;
    public TextMeshProUGUI finalText;
    public AudioClip Wrong;
    public AudioClip right;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadQuestion(int number)
    {
        ClearAnswers();
        questionText.text = questions.questions[number].question;
        ShuffleArray(questions.questions[number].answers);
        foreach(Answer answer in questions.questions[number].answers){
            GameObject a = Instantiate(answerPrefab);
            a.transform.SetParent(answersParent);
            a.transform.localScale = new Vector3(1, 1, 1);
            AnswerButton btn = a.GetComponent<AnswerButton>();
            btn.text.text = answer.answer;
            btn.correct = answer.correct;
        }
        
    }

    void ShuffleArray<T>(T[] array)
    {
        System.Random random = new System.Random();

        
        for (int i = array.Length - 1; i > 0; i--)
        {
            int randomIndex = random.Next(0, i + 1);

            T temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }

    public void ClearAnswers()
    {
        foreach(Transform child in answersParent) {
            Destroy(child.gameObject);
        }
    }


    public IEnumerator LoadNextQuestion()
    {
        questionNum++;
        yield return new WaitForSeconds(3f);
        
        if (questionNum >= questions.questions.Length)
        {
            EndGame();
        }
        LoadQuestion(questionNum);

    }
    public void LoadNewQuestion()
    {
        StartCoroutine(LoadNextQuestion());
    }

    public void UpadteScore(int points)
    {
        score += points;
        scoreText.text = "Score:" + score + "/" + questions.questions.Length;
    }

    public void StartGame()
    {
        ShuffleArray(questions.questions);
        quiz.SetActive(true);
        score = 0;
        questionNum = 0;
        UpadteScore(0);
        endMenu.SetActive(false);
        LoadQuestion(questionNum);
    }


    public void EndGame()
    {
        finalText.text = "You scored: " + score + "/" + questions.questions.Length;
        endMenu.SetActive(true);
        quiz.SetActive(false);
    }

    public GameObject quizCanva;
    public void LeaveGame()
    {
        quizCanva.SetActive(false);
    }

    public void DisableButtons()
    {
        foreach(Transform child in answersParent)
        {
            Button btn = child.GetComponent<Button>();
            if (btn != null)
            {
                btn.interactable = false;
            }
        }
    }
}


