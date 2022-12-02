using System.Collections;
using System.Collections.Generic;
using ArrayStimulator;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionSort : MonoBehaviour
{
    bool swap;
    public GameObject arrayElement;
    List<ArrayElement> list = new List<ArrayElement>();

    int i = 0;

    public TMP_InputField value;
    // public GameObject start;
    // public GameObject end;
    int j = 0;
    int k = 0;

    public void sort()
    {
        if (i < list.Count - 1)
        {
            if (k == list.Count - 1)
            {
                i++;
                k=i+1;
            }
            int min_idx = i;
            if (k < list.Count)
            {
                if (list[k].value > list[min_idx].value)
                {
                    min_idx = k;
                }
                var mat0 = list[k].Element.GetComponentInChildren<Renderer>().material;
                var mat1 = list[min_idx].Element.GetComponentInChildren<Renderer>().material;
                var t = list[k];
                list[k] = list[min_idx];
                list[min_idx] = t;

                mat1.color = Color.black;
                mat0.color = Color.blue;

                StartCoroutine(sorting(list[k].Element.transform.position, list[min_idx].Element.transform.position, k, min_idx));
                k++;
            }
            else
            {
                Debug.Log("Pointer Reached the Length");
            }
        }
    }

    void Update(){
           if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Data Structure");
                return;
            }
        }
    }
    IEnumerator sorting(Vector3 startPos, Vector3 endPos, int start, int end)
    {
        float journey = 0f;
        while (true)
        {
            journey = journey + Time.deltaTime;
            float percent = Mathf.Clamp01(journey / 2);

            list[start].Element.transform.position = Vector3.Lerp(startPos, endPos, percent);

            list[end].Element.transform.position = Vector3.Lerp(endPos, startPos, percent);

            if (list[start].Element.transform.position == endPos) break;

            yield return null;
        }
    }

    public void Add()
    {
        list.Add(new ArrayElement(int.Parse(value.text.ToString()), Instantiate(arrayElement, Vector3.left * 10 + j * new Vector3(1.5f, 0, 0), Quaternion.identity)));
        j++;
    }

}
