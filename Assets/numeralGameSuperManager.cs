using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numeralGameSuperManager : MonoBehaviour
{
    public int numeralGameChecker;
    public GameObject questManager;

    private int checker = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(numeralGameChecker);

        if(numeralGameChecker == 3 && checker == 0)
        {
            ++checker;
          
            questManager questMan = questManager.GetComponent<questManager>();
            questMan.questCompleter(2);
        }
    }
}
