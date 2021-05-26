//Working with Variables and Metots

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{  
    public string firstName = "Tirendaz";

    public int age = 33;
    public float number = 5.7f;
    public string job = "Game Developer";
    public bool isStudent = true;

    float implicitConversion = 3;
    int explicitConversion = (int) 3.14;

    /*2*3+8:4+5
    50>30*/

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log("love to learn");
        Debug.Log(firstName);*/
        //Debug.LogFormat("Don't forget to subscribe to {0} Academy", firstName);
        //Debug.Log($"My name is {firstName}. I want to be {job}");
        /*var secondNumber = 5;
        Debug.Log(explicitConversion);*/
        Debug.Log(Add(4,5));
    
    }

    public int Add(int number1, int number2)
    {
        //Debug.Log(3+5);
        int sum =number1+number2;
        //Debug.Log(sum);
        return sum;
    }
    // Update is called once per frame
    void Update() 
    {
        
    }
}

