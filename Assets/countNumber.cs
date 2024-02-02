using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class countNumber : MonoBehaviour
{
    // Start is called before the first frame update
    public Text groundTrue;
    public Text userInput;

    public Text finishBool;

    int countedNumber= 0;
    void Start()
    {
        userInput.text = countedNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addOne(){
        countedNumber++;
        userInput.text = countedNumber.ToString();

    }
    public void finishEnd(){
        finishBool.text = "All Done!";
    }
   
}
