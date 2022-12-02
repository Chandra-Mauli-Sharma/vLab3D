using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataStructureMenuManager : MonoBehaviour
{
    public void LinkedList()
    {
        SceneManager.LoadScene("Linked List");
    }

    public void Stack()
    {
        SceneManager.LoadScene("Stack");
    }

    public void BinarySearch()
    {
        SceneManager.LoadScene("Binary Search");
    }

    public void BubbleSort()
    {
        SceneManager.LoadScene("Bubble Sort");
    }

    public void SelectionSort()
    {
        SceneManager.LoadScene("Selection Sort");
    }

    public void Dijkstra()
    {
        SceneManager.LoadScene("Dijkstra");
    }

    public void LinearSearch()
    {
        SceneManager.LoadScene("Linear Search");
    }

    public void Queue()
    {
        SceneManager.LoadScene("Queue");
    }
        void Update(){
        if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Main Menu");
                return;
            }
        }
    }
}
