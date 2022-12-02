using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectronicsMenuManager : MonoBehaviour
{
    public void LogicGates(){
        SceneManager.LoadScene("Logic Gates");
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
