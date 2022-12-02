using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicGates : MonoBehaviour
{
    public GameObject And;
    public GameObject Or;
    public GameObject Not;
    public GameObject Nand;
    public GameObject Nor;
    public GameObject Xor;
    GameObject present;

    void Update(){
        if(Application.platform==RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){
                SceneManager.LoadScene("Electronics");
                return;
            }
        }
    }
    public void AndGate(){
        Destroy(present);
        present=Instantiate(And,Vector3.zero,Quaternion.identity);
    }
    public void OrGate(){
        Destroy(present);
        present=Instantiate(Or,Vector3.zero,Quaternion.identity);
    }
    public void NotGate(){
        Destroy(present);
        present=Instantiate(Not,Vector3.zero,Quaternion.identity);
    }
    public void NandGate(){
        Destroy(present);
        present=Instantiate(Nand,Vector3.zero,Quaternion.identity);
    }
    public void NorGate(){
        Destroy(present);
        present=Instantiate(Nor,Vector3.zero,Quaternion.identity);
    }
    public void XorGate(){
        Destroy(present);
        present=Instantiate(Xor,Vector3.zero,Quaternion.identity);
    }
}
