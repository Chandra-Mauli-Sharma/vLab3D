using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayStimulator;
using UnityEngine.UI;
using TMPro;

public class BinarySearch : MonoBehaviour
{
    public GameObject arrayElement;


    List<ArrayElement> list=new List<ArrayElement>();
    int i = 0;
    int low=0;
    int high;
    int j = 0;

    public TMP_InputField value;

    public TMP_InputField search;
    public TMP_Text text;
    bool flag=true;

    int r=-1;

    public void Search()
    {
        int x=int.Parse(search.text.ToString());
        if ((low <= high)&&flag)
        { 
            int mid = low + (high - low) / 2;

            if (list[mid].value == x){
                flag=false;
                r=mid;
            } 

            if (list[mid].value < x){
                for(int i=0;i<=mid;i++){
                    list[i].Element.GetComponentInChildren<Renderer>().material.color=Color.white;
                }

                low = mid + 1;
            }
            else{
                for(int i=mid;i<=high;i++){
                    list[i].Element.GetComponentInChildren<Renderer>().material.color=Color.white;
                }
                high = mid - 1;
            }
        }
        else
        {
            if(!flag){
                list[r].Element.GetComponentInChildren<Renderer>().material.color=Color.black;
                StartCoroutine(move(list[r].Element,list[r].Element.transform.position));
            
                
            }
            text.text = "Pointer Reached the Length";
        }

    }

    public void Add(){
        if(j!=0&&int.Parse(value.text.ToString())<list[high].value){
            text.text="Array should be sorted!!!";
        } else{
            list.Add(new ArrayElement(int.Parse(value.text.ToString()), Instantiate(arrayElement, Vector3.left*10+j*new Vector3(1.5f,0,0), Quaternion.identity)));
            high=j;
            j++;
        }
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
