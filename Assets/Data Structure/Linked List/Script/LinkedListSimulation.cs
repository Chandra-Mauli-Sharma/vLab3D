using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using LinkedSimulation;
using UnityEngine.SceneManagement;

public class LinkedListSimulation : MonoBehaviour
{
    LinkedList<Node> list = new LinkedList<Node>();
    public TMP_InputField value;
    int pos=6;
    int loc=0;
    public GameObject node;
    public GameObject InsertionAlgo;
    public GameObject DeletionAlgo;

    void Update(){
           if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Data Structure");
                return;
            }
        }
    }
    public void AddNode()
    {
        loc++;
        list.AddFirst(new Node(value.text,pos,loc));
        var newNode=Instantiate(node, new Vector3(pos,2.7f,3.3f), Quaternion.identity);
        newNode.name=loc.ToString();
        newNode.GetComponentInChildren<Canvas>().GetComponentInChildren<TMP_Text>().text=value.text;
        value.text="";
        pos-=3;
        StartCoroutine(ShowInsertionAlgo());
    }

    public void DeleteNode(){
        Destroy(GameObject.Find(list.Last.Value.loc.ToString()));
        list.RemoveLast();
        loc--;
        StartCoroutine(ShowDeletionAlgo());
    }

    IEnumerator ShowInsertionAlgo(){
        InsertionAlgo.SetActive(true);
        yield return new WaitForSeconds(5);
        InsertionAlgo.SetActive(false);
    }

    IEnumerator ShowDeletionAlgo(){
        DeletionAlgo.SetActive(true);
        yield return new WaitForSeconds(5);
        DeletionAlgo.SetActive(false);
    }
}


