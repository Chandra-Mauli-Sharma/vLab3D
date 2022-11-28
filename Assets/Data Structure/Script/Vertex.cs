using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vertex : MonoBehaviour
{
    public int value;
    public GameObject Element;

    void onStart(){
        Element=gameObject;
    }

    public Vertex(int value,GameObject element){
        this.value=value;
        this.Element=element;
        element.GetComponentInChildren<TMP_Text>().text=value.ToString();
    }

    public override bool Equals(object other)
    {
        return this.value.Equals((other as Vertex).value);
    }

    public override int GetHashCode()
    {
        return value.GetHashCode();
    }
}
