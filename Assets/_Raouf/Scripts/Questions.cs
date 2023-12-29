using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public Question[] questions = {new Question
        {
            question = "man 9a2il: \"3endi mochkila fi hyati ysemoha nti\"",
            answers = new Answer[]
            {
                new Answer { answer = "Cheb bello", correct = false },
                new Answer { answer = "Cheb Fares", correct = true },
                new Answer { answer = "Didin klash", correct = false },
                new Answer { answer = "Aymen serhani", correct = false },
            }
        },
        new Question
        {
            question = "man 9a2il: \"flamour ana lfidel khatini lcocktail\"",
            answers = new Answer[]
            {
                new Answer { answer = "Cheb bello", correct = false },
                new Answer { answer = "Cheb Fares", correct = false },
                new Answer { answer = "Didin klash", correct = false },
                new Answer { answer = "Aymen serhani", correct = true },
            }
        },
        new Question
        {
            question = "man 9a2il: \"tiyara tiyara wawawawa\"",
            answers = new Answer[]
            {
                new Answer { answer = "Cheb bello", correct = true },
                new Answer { answer = "Cheb Fares", correct = false },
                new Answer { answer = "Didin klash", correct = false },
                new Answer { answer = "Aymen serhani", correct = false },
            }
        }

    };



}
public class Question
{
    public string question;
    public Answer[] answers;
}

public class Answer
{
    public bool correct;
    public string answer;
}