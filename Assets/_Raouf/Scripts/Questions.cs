using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public Question[] questions = {
        new Question
        {
            question = "What is the primary purpose of a game design document (GDD)?",
            answers = new Answer[]
            {
                new Answer { answer = "Provide a detailed story for the game", correct = false },
                new Answer { answer = "Outline the technical specifications of the game engine", correct = false },
                new Answer { answer = "Document the vision, mechanics, and features of the game", correct = true },
                new Answer { answer = "Record player feedback during beta testing", correct = false },
            }
        },
        new Question
        {
            question = "In game design, what does the term 'UI' stand for?",
            answers = new Answer[]
            {
                new Answer { answer = "User Interface", correct = true },
                new Answer { answer = "Unique Interaction", correct = false },
                new Answer { answer = "Ultimate Invention", correct = false },
                new Answer { answer = "Underlying Innovation", correct = false },
            }
        },
        new Question
        {
            question = "What does the term 'level design' refer to in the context of game development?",
            answers = new Answer[]
            {
                new Answer { answer = "Designing characters for the game", correct = false },
                new Answer { answer = "Creating the visual style of the game", correct = false },
                new Answer { answer = "Crafting the layout and structure of game environments", correct = true },
                new Answer { answer = "Planning the marketing strategy for the game", correct = false },
            }
        },
        new Question
        {
            question = "Which game design element focuses on the balance between risk and reward to engage players?",
            answers = new Answer[]
            {
                new Answer { answer = "Pacing", correct = false },
                new Answer { answer = "Progression", correct = false },
                new Answer { answer = "Challenge", correct = true },
                new Answer { answer = "Flow", correct = false },
            }
        },
        new Question
        {
            question = "What is the purpose of playtesting in game development?",
            answers = new Answer[]
            {
                new Answer { answer = "Showcasing the game to potential investors", correct = false },
                new Answer { answer = "Identifying and fixing bugs and glitches", correct = true },
                new Answer { answer = "Generating hype and anticipation for the game", correct = false },
                new Answer { answer = "Determining if the game's story is engaging", correct = false },
            }
        },
        new Question
        {
            question = "Which term describes the psychological tricks used to keep players engaged in a game?",
            answers = new Answer[]
            {
                new Answer { answer = "Gamification", correct = true },
                new Answer { answer = "Immersion", correct = false },
                new Answer { answer = "Monetization", correct = false },
                new Answer { answer = "Exploitation", correct = false },
            }
        },
        new Question
        {
            question = "What is the significance of the 'sandbox' in game design?",
            answers = new Answer[]
            {
                new Answer { answer = "A type of game genre", correct = false },
                new Answer { answer = "A testing environment for developers", correct = false },
                new Answer { answer = "An open-world design where players have freedom", correct = true },
                new Answer { answer = "A place to store in-game assets", correct = false },
            }
        },
        new Question
        {
            question = "What does the term 'NPC' stand for in game design?",
            answers = new Answer[]
            {
                new Answer { answer = "Non-Playable Character", correct = true },
                new Answer { answer = "New Player Challenge", correct = false },
                new Answer { answer = "Non-Profit Company", correct = false },
                new Answer { answer = "Narrative Plot Control", correct = false },
            }
        },
        new Question
        {
            question = "What is the purpose of the 'flow state' in game design?",
            answers = new Answer[]
            {
                new Answer { answer = "Creating a visually appealing game world", correct = false },
                new Answer { answer = "Maximizing in-game profits", correct = false },
                new Answer { answer = "Immersing players in a state of focused concentration and enjoyment", correct = true },
                new Answer { answer = "Generating a sense of competition among players", correct = false },
            }
        },
        new Question
        {
            question = "Which game design principle emphasizes providing a variety of challenges to keep players engaged?",
            answers = new Answer[]
            {
                new Answer { answer = "Balance", correct = false },
                new Answer { answer = "Diversity", correct = true },
                new Answer { answer = "Consistency", correct = false },
                new Answer { answer = "Repetition", correct = false },
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