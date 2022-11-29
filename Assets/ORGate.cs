using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORGate : MonoBehaviour
{
    public bool input1;
    public bool input2;
    public bool output;

    public GameObject input1Object;
    public GameObject input2Object;

    public GameObject outputObject;

    void Start()
    {
        input1=input2=output=false;
    }

    void Update()
    {
        input1Object.GetComponent<SpriteRenderer>().color=input1?Color.green:Color.red;
        input2Object.GetComponent<SpriteRenderer>().color=input2?Color.green:Color.red;

        output=(input1||input2);

        outputObject.GetComponent<SpriteRenderer>().color=output?Color.green:Color.red;

    }

    public void toggleInput1(){
        input1=!input1;
    }

    public void toggleInput2(){
        input2=!input2;
    }
}
