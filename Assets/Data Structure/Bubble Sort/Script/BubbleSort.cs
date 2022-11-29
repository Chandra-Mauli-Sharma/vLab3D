
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayStimulator;
using TMPro;

public class BubbleSort : MonoBehaviour
{
    bool swap;
    public GameObject arrayElement;
    List<ArrayElement> list=new List<ArrayElement>();

    int i = 0;

    public TMP_InputField value;
     int j=0;


    public void Add(){
        list.Add(new ArrayElement(int.Parse(value.text.ToString()), Instantiate(arrayElement, Vector3.left*10+j*new Vector3(1.5f,0,0), Quaternion.identity)));
        j++;
    }

    

    public void sort(){

        if(i==list.Count-1){
            i=0;
        }

        if(i < list.Count){
            if(list[i].value>list[i+1].value){
                
                var mat0 = list[i].Element.GetComponentInChildren<Renderer>().material;
                var mat1 = list[i+1].Element.GetComponentInChildren<Renderer>().material;
                var t=list[i];
                list[i]=list[i+1];
                list[i+1]=t;

                mat0.color=Color.black;
                mat1.color=Color.blue;

                StartCoroutine(sorting(list[i].Element.transform.position,list[i+1].Element.transform.position,i,i+1));
            }
            i++;
        } else{
            Debug.Log("Pointer Reached the Length");
        }
    }

    IEnumerator sorting(Vector3 startPos,Vector3 endPos,int start,int end){
        float journey = 0f;
        while (true)
        {
            journey = journey + Time.deltaTime;
            float percent = Mathf.Clamp01(journey/2);
            
            list[start].Element.transform.position = Vector3.Lerp(startPos, endPos, percent);

            list[end].Element.transform.position= Vector3.Lerp(endPos, startPos, percent);
            
            if(list[start].Element.transform.position==endPos) break;

            yield return null;
        }
    }
}
