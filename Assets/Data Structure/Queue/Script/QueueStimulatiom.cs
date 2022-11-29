using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QueueStimulator;
using System.IO;
using TMPro;


public class QueueStimulatiom : MonoBehaviour
{
    public GameObject queueElement;
    public TMP_InputField value;
    Queue<QueueElement> queue=new Queue<QueueElement>();
    public GameObject posTracker;

    public void EnqueueElement()
    {
        
        StartCoroutine(move(posTracker,posTracker.transform.position));
        queue.Enqueue(new QueueElement(value.text, Instantiate(queueElement, new Vector3(0.95f,0.641f,-11.5f), Quaternion.identity,posTracker.transform)));
    }

    public void DequeueElement()
    {
        Destroy(queue.Peek().element,2);
        queue.Dequeue();
        posTracker.transform.position -= new Vector3(0, 0.5f, 0);
    }

    IEnumerator move(GameObject present,Vector3 dest){
        float journey = 0f;
        while (true)
        {
            journey = journey + Time.deltaTime;
            float percent = Mathf.Clamp01(journey/2);
            
            present.transform.position = Vector3.Lerp(present.transform.position, dest+new Vector3(0,0,1.5f), percent);

            if(dest+new Vector3(0,0,1.5f)==present.transform.position) break;
            yield return null;
        }
    }
}
