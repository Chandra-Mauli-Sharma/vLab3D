using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StackStimulator;
using UnityEditor.Scripting.Python;
using System.IO;

public class StackStimulation : MonoBehaviour
{
    public GameObject stackElement;
    Stack<StackElement> stack = new Stack<StackElement>();
    public GameObject posTracker;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        RunEnsureNaming();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static void RunEnsureNaming()
    {
        string scriptPath = Path.Combine(Application.dataPath, "ex.py");
        PythonRunner.RunFile(scriptPath);
    }

    public void PushElement()
    {
        stack.Push(new StackElement(posTracker.transform.position.y, Instantiate(stackElement, posTracker.transform.position, Quaternion.identity)));
        posTracker.transform.position += new Vector3(0, 0.5f, 0);
    }

    public void PopElement()
    {
        stack.Peek().element.GetComponent<Rigidbody>().AddForce(new Vector3(0,100,40),ForceMode.Impulse);
        Destroy(stack.Peek().element,2);
        stack.Pop();
        posTracker.transform.position -= new Vector3(0, 0.5f, 0);
    }
}
