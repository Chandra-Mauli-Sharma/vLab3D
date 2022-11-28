using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayStimulator;
using UnityEngine.UI;
using TMPro;

public class LinearSearch : MonoBehaviour
{
    public GameObject arrayElement;


    List<ArrayElement> list=new List<ArrayElement>();
    int i = 0;
    int j = 0;

    public TMP_InputField value;

    public TMP_InputField search;
    public TMP_Text text;

    public void Search()
    {
        if (i < list.Count)
        { 
            var mat = list[i].Element.GetComponentInChildren<Renderer>().material;
            if (int.Parse(search.text.ToString()) == list[i].value)
            {
                StartCoroutine(move(list[i].Element,list[i].Element.transform.position));
                mat.color = Color.cyan;
                
            }
            else
            {
                mat.color = Color.black;
            }
            i++;
            text.text = "At "+i;
        }
        else
        {
            text.text = "Pointer Reached the Length";
        }

    }

    public void Add(){
        list.Add(new ArrayElement(int.Parse(value.text.ToString()), Instantiate(arrayElement, Vector3.left*10+j*new Vector3(1.5f,0,0), Quaternion.identity)));
        j++;
    }

    IEnumerator move(GameObject present,Vector3 dest){
        float journey = 0f;
        while (true)
        {
            journey = journey + Time.deltaTime;
            float percent = Mathf.Clamp01(journey/5);
            
            present.transform.position = Vector3.Lerp(present.transform.position, dest+new Vector3(0,0,-1.5f), percent);

            if(dest+new Vector3(0,0,1.5f)==present.transform.position) break;
            yield return null;
        }
    }
}
