
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayStimulator;

public class BubbleSort : MonoBehaviour
{
    string str;
    bool swap;
    public GameObject arrayElement;
    ArrayElement[] arr=new ArrayElement[5];
    // public GameObject start;
    // public GameObject end;
     int j=0;
    // Start is called before the first frame update
    void Start()
    {
        int[] p={5,6,1,2,10};

        for(int i=0;i<arr.Length;i++){
            arr[i]=new ArrayElement(p[i], Instantiate(arrayElement, new Vector3(i*3,0,0), Quaternion.identity));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sort(){
        str="";
        if(j==arr.Length-1){
            j=0;
        }

        if(arr[j].value>arr[j+1].value){
            
            var t=arr[j];
            arr[j]=arr[j+1];
            arr[j+1]=t;

            swap=false;
            var p=arr[j+1].Element.transform.position;
            StartCoroutine(sorting(arr[j].Element.transform.position,arr[j+1].Element.transform.position,j,j+1));
            
            if(p==arr[j].Element.transform.position) StopCoroutine(sorting(arr[j].Element.transform.position,arr[j+1].Element.transform.position,j,j+1));
            // var p=arr[j].Element.transform.position;
            // arr[j].Element.transform.position=arr[j+1].Element.transform.position;
            // arr[j].Element.transform.position=p;
        }


        // foreach (var item in arr)
        // {
        //     str=str+item.value+" "+item.Element.transform.position;   
        // }
        
        j++;
    }

    IEnumerator sorting(Vector3 startPos,Vector3 endPos,int start,int end){
        float journey = 0f;
        while (true)
        {
            journey = journey + Time.deltaTime;
            float percent = Mathf.Clamp01(journey/2);
            
            arr[start].Element.transform.position = Vector3.Lerp(startPos, endPos, percent);

            arr[end].Element.transform.position= Vector3.Lerp(endPos, startPos, percent);
            
            Debug.Log(str+" j:"+j+" "+percent+" "+journey);
            yield return null;
        }
    }
}
