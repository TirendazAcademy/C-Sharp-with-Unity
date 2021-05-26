//Control Flow and Collection Types

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{  
    // Start is called before the first frame update
    void Start()
    {
        //Using if-else statement
        /*int number1 = 10;
        int number2 = 20;
    
        if (number1 > number2)
        {
            Debug.Log("number1, is greater than number2.");
        }
        else
        {
            Debug.Log("number1, is smaller than number2.");
        }*/

        //Using switch statement
        /*{
        string weather = "snow";
        switch (weather)
        {
            case "rainy":
                Debug.Log("take an umbrella");
                break;
            case "snow":
                Debug.Log("wear a sweater");
                break;
            default:
                Debug.Log("go to picnic");
                break;
        }*/

        //Arrays
        /*int[] playerScores = new int[3];
        int[] playerScores = new int[] {156, 289, 234};
        int[] playerScores = {156, 289, 234};
        Debug.Log(playerScores[0]);
        playerScores[2] = 777;
        Debug.Log(playerScores[2]);
        */

        //Lists
        List<string> city = new List<string>() {"Ankara", "Istanbul"};
        /*city.Add("Bursa");
        city.Insert(0, "Adana");
        city.Remove("Ankara");
        Debug.Log(city[0]);*/

        //Dictionary
        /*Dictionary<string, int> cityNumber = new Dictionary<string, int>() 
        {
            {"Ankara", 6 },
            {"Istanbul", 34},
            {"Bursa", 16}
        };
        Debug.Log(cityNumber.Count);
        Debug.Log(cityNumber["Ankara"]);
        cityNumber.Add("Adana", 1);
        Debug.Log(cityNumber["Adana"]);*/

        //For Loops
        /*for (int i=0; i < city.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, city[i]);
        }*/

        //Foreach Loops
        /*foreach (string item in city)
        {
            Debug.LogFormat("Name of City : {0}", item);
        }*/

        int playerNumber = 3;
        while (playerNumber>0)
        {
            Debug.Log("Play game!");
            //In each loop, the value of playerNumber decreases by 1.
            playerNumber -- ;
        }
        Debug.Log("End game!");

    }

    // Update is called once per frame
    void Update() 
    {
        
    }
}