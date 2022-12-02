using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : MonoBehaviour
{
    public bool input1;
    public bool output;

    public GameObject input1Object;

    public GameObject outputObject;

    void Start()
    {
        input1=output=false;
    }

    void Update()
    {
        input1Object.GetComponent<SpriteRenderer>().color=input1?Color.green:Color.red;

        output=!(input1);

        outputObject.GetComponent<SpriteRenderer>().color=output?Color.green:Color.red;

    }

    public void toggleInput1(){
        input1=!input1;
    }

}
