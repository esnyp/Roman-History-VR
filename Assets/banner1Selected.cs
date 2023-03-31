using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banner1Selected : MonoBehaviour
{
    public quizGameManager quizParent;

    public void changeSelectedBanner()
    {
        if (gameObject.name == "Banner1")
        {
            quizParent.setSelectedBanner(1);
            quizParent.answerResolver(1, 1);
        }
        else if (gameObject.name == "Banner2")
        {
            quizParent.setSelectedBanner(2);
            quizParent.answerResolver(1, 2);
        }
        else if (gameObject.name == "Banner3")
        {
            quizParent.setSelectedBanner(3);
            quizParent.answerResolver(1, 3);
        }
        else if (gameObject.name == "Banner4")
        {
            quizParent.setSelectedBanner(4);
            quizParent.answerResolver(1, 4);
        }
    }
}
