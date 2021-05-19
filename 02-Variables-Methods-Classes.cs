//Variables, Methods, and Classes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public int firstNumber = 30;
    public int secondNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        Compute();
    }

    void Compute()
    {
        Debug.Log(firstNumber + secondNumber);
    }

    // This is 
    // a multi-line comment

    // Update is called once per frame
    void Update()
    {
        
    }
}