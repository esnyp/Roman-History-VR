using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static questManager;

public class quizGameManager : MonoBehaviour
{
    public quizGameInteractor quizGamInt;
    public int selectedBanner;
    //

    public TMP_Text questionTitle;

    public TMP_Text button1Text;
    public TMP_Text button2Text;
    public TMP_Text button3Text;
    public TMP_Text button4Text;
    //

    public Dictionary<int, questionData> dictionaryQuestions = new Dictionary<int, questionData>();

    // Start is called before the first frame update
    void Start()
    {
        dictionaryQuestions.Add(1, new questionData { questionID = 1, questionTitle = "Which of these is a type of Roman home?",
            answer1 = "Ranch", answer2 = "Domus", answer3 = "Tudor", answer4 = "Mediterranean", correctAnswer = 2});

      
    }

    // Update is called once per frame
    void Update()
    {
        selectedBanner = quizGamInt.handSelectedBanner;
        buttonTextAssigner();
    }

    public struct questionData{
        public int questionID;
        public string questionTitle;
        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public int correctAnswer;
    }

    public void buttonTextAssigner()
    {
        questionTitle.text = dictionaryQuestions[1].questionTitle;
        button1Text.text = dictionaryQuestions[1].answer1;
        button2Text.text = dictionaryQuestions[1].answer2;
        button3Text.text = dictionaryQuestions[1].answer3;
        button4Text.text = dictionaryQuestions[1].answer4;
    }

    public void answerResolverQ1()
    {
        if(selectedBanner == dictionaryQuestions[1].correctAnswer)
        {
            Debug.Log("correct");
        }
        else
        {
            Debug.Log("wrong");
        }
    }

   

    
}
