using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static questManager;

public class quizGameManager : MonoBehaviour
{
    public int selectedBanner;
    public int currentQuestionID = 1;
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


        dictionaryQuestions.Add(1, new questionData // add questions and answers to dictionary
        { questionID = 1, 
          questionTitle = "Which of these is a type of Roman home?",
            answer1 = "Ranch", 
            answer2 = "Domus", 
            answer3 = "Tudor", 
            answer4 = "Mediterranean", 
            correctAnswer = 2,
            answered = false
        });

        dictionaryQuestions.Add(2, new questionData
        {
            questionID = 2,
            questionTitle = "What was a popular Roman dish made from a mixture of fish and various spices?",
            answer1 = "Garum",
            answer2 = "Hummus",
            answer3 = "Polenta",
            answer4 = "Risotto",
            correctAnswer = 1,
            answered = false
        });


        currentQuestionID = 2;
        buttonTextAssigner(currentQuestionID);

    }
     public struct questionData{
        public int questionID;
        public string questionTitle;
        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public int correctAnswer;
        public bool answered;
    }
    // Update is called once per frame
    

    void Update()
    {
        
        Debug.Log(getSelectedBanner());
        Debug.Log(dictionaryQuestions[1].answered + "q1");
        Debug.Log(dictionaryQuestions[2].answered + "q2");
    }

   

    public void buttonTextAssigner(int questionID)
    {
        questionTitle.text = dictionaryQuestions[questionID].questionTitle;
        button1Text.text = dictionaryQuestions[questionID].answer1;
        button2Text.text = dictionaryQuestions[questionID].answer2;
        button3Text.text = dictionaryQuestions[questionID].answer3;
        button4Text.text = dictionaryQuestions[questionID].answer4;
    }

    public void answerResolver(int questionID, int selectedBanner)
    {



       if(selectedBanner == dictionaryQuestions[questionID].correctAnswer)
        {
            Debug.Log("correct");
            dictionaryUpdaterAnswered(questionID); //updates the dictionary to change answered to true


        }
        else
        {
            Debug.Log("incorrect");
            dictionaryUpdaterAnswered(questionID);
        }
    }

    public void setSelectedBanner(int bannerID)
    {
        selectedBanner = bannerID;
    }

    public int getSelectedBanner()
    {
        return selectedBanner;
    }

    public void dictionaryUpdaterAnswered(int id)
    {
        dictionaryQuestions[id] = new questionData
        {
            questionID = dictionaryQuestions[id].questionID,
            questionTitle = dictionaryQuestions[id].questionTitle,
            answer1 = dictionaryQuestions[id].answer1,
            answer2 = dictionaryQuestions[id].answer2,
            answer3 = dictionaryQuestions[id].answer3,
            answer4 = dictionaryQuestions[id].answer4,
            correctAnswer = dictionaryQuestions[id].correctAnswer,
            answered = true
        };
    }


}
