using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Edge : MonoBehaviour
{
    public Vertex start;
    public Vertex end;

    public int weight;
    public GameObject Element;

    void Start(){
        Element=gameObject;
    }

    public Edge(Vertex start,Vertex end,GameObject Element,int weight){
        this.Element=Element;
        Element.GetComponentInChildren<TMP_Text>().text=weight.ToString();
        var line=Element.AddComponent<LineRenderer>();
        line.material=new Material(Shader.Find("Sprites/Default"));

        this.weight=weight;
        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.grey, 0.0f), new GradientColorKey(Color.black, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        line.colorGradient = gradient;
        line.SetPosition(0,start.Element.transform.position);
        line.SetPosition(1,end.Element.transform.position);
        
    }
}
