using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StackStimulator;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;

public class StackStimulation : MonoBehaviour
{
    public GameObject stackElement;
    public TMP_InputField value;
    Stack<StackElement> stack = new Stack<StackElement>();
    public GameObject posTracker;

    public void PushElement()
    {
        stack.Push(new StackElement(value.text, Instantiate(stackElement, posTracker.transform.position, Quaternion.identity)));
        posTracker.transform.position += new Vector3(0, 0.5f, 0);
    }

    public void PopElement()
    {
        stack.Peek().element.GetComponent<Rigidbody>().AddForce(new Vector3(0,100,40),ForceMode.Impulse);
        Destroy(stack.Peek().element,2);
        stack.Pop();
        posTracker.transform.position -= new Vector3(0, 0.5f, 0);
    }
    void Update(){
        if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Data Structure");
                return;
            }
        }
    }
}
