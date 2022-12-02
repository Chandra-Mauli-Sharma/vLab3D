using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void DataStructure(){
        SceneManager.LoadScene("Data Structure");
    }

    public void Electrical(){
        SceneManager.LoadScene("Electrical");
    }

    public void Electronics(){
        SceneManager.LoadScene("Electronics");
    }


}
