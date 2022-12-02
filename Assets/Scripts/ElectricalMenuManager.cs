using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectricalMenuManager : MonoBehaviour
{
    public void Resistor(){
        SceneManager.LoadScene("Familiarization Resistor");
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
