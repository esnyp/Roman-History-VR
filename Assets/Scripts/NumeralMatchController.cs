using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumeralMatchController : MonoBehaviour
{
    public TMP_Text number;
    public TMP_Text numeral1;
    public TMP_Text numeral2;
    public TMP_Text numeral3;

    private Dictionary<string, string> numberKeyNumeralValue = new Dictionary<string, string>();
    private Dictionary<string, string> numeralKeyNumberValue = new Dictionary<string, string>();
    
    // Start is called before the first frame update
    void Start()
    {     
        addDictionary();
        setTextValues();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void setTextValues()
    {
        int selectedNumber = Random.Range(1, 11);
        string selectedNumberString = selectedNumber.ToString(); //need to convert to string so it works with dictionary        

        int randomBannerInt = Random.Range(1, 4);
        string randomBannerIntString = randomBannerInt.ToString();  

        int ranWrongAnswer1 = getRandomInt(selectedNumber);
        string ranWrongAnswer1String = ranWrongAnswer1.ToString();

        int ranWrongAnswer2 = getRandomInt(selectedNumber);
        string ranWrongAnswer2String = ranWrongAnswer2.ToString();

        int ranWrongAnswer3 = getRandomInt(selectedNumber);
        string ranWrongAnswer3String = ranWrongAnswer3.ToString();

        Debug.Log(randomBannerIntString);

        number.text = selectedNumberString; // sets the random number to be equal to the text

       

        switch (randomBannerIntString) //selects the text infront of a banner and sets it to the value of the keys for selectedNumber
        {
            case "1":             
                numeral1.text = numberKeyNumeralValue[selectedNumberString];
                //Debug.Log(numberKeyNumeralValue[randomBannerIntString]);
                break;
            case "2":
                numeral2.text = numberKeyNumeralValue[selectedNumberString];
                //Debug.Log(numberKeyNumeralValue[randomBannerIntString]);
                break;
            case "3":
                numeral3.text = numberKeyNumeralValue[selectedNumberString];
                //Debug.Log(numberKeyNumeralValue[randomBannerIntString]);
                break;
        }

        if (numeral1.text.Contains("Dummy"))
        {
            numeral1.text = numberKeyNumeralValue[ranWrongAnswer1String];
        }
        if (numeral2.text.Contains("Dummy"))
        {
            numeral2.text = numberKeyNumeralValue[ranWrongAnswer2String];
        }
        if (numeral3.text.Contains("Dummy"))
        {
            numeral3.text = numberKeyNumeralValue[ranWrongAnswer3String];
        }


    }

    int getRandomInt(int selectedNumber)
    {
        int randomNum = Random.Range(1, 11);

        while (randomNum == selectedNumber)
        {
            randomNum = Random.Range(1, 11);
        }

        return randomNum;
    }

    void addDictionary()
    {
        numeralKeyNumberValue.Add("I", "1");
        numeralKeyNumberValue.Add("II", "2");
        numeralKeyNumberValue.Add("III", "3");
        numeralKeyNumberValue.Add("IV", "4");
        numeralKeyNumberValue.Add("V", "5");
        numeralKeyNumberValue.Add("VI", "6");
        numeralKeyNumberValue.Add("VII", "7");
        numeralKeyNumberValue.Add("VIII", "8");
        numeralKeyNumberValue.Add("IX", "9");
        numeralKeyNumberValue.Add("X", "10");

        //-------------------------------------------------------//

        numberKeyNumeralValue.Add("1", "I");
        numberKeyNumeralValue.Add("2", "II");
        numberKeyNumeralValue.Add("3", "III");
        numberKeyNumeralValue.Add("4", "IV");
        numberKeyNumeralValue.Add("5", "V");
        numberKeyNumeralValue.Add("6", "VI");
        numberKeyNumeralValue.Add("7", "VII");
        numberKeyNumeralValue.Add("8", "VIII");
        numberKeyNumeralValue.Add("9", "IX");
        numberKeyNumeralValue.Add("10", "X");
    }

}
