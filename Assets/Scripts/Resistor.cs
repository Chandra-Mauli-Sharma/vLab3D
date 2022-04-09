using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Resistor : MonoBehaviour
{

    Dictionary<string, Color> hash = new Dictionary<string, Color>();
    Material[] m_Material;
    public Slider slider;
    public TextMeshProUGUI textMeshPro;
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().materials;
        initializeColorBand();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = slider.value.ToString() + " ohm";

        slider.onValueChanged.AddListener(delegate
        {
            resistanceCal();
            reset();
        });

    }

    public void resistanceCal()
    {
        var m = slider.value.ToString();
        if (m.Length == 2)
        {
            m = "0" + m;
        }
        if (m.Length == 1)
        {
            m = "00" + m;
        }
        ColorChange(m);
    }
    public void reset()
    {
        num = 0;
    }


    public void ColorChange(string m)
    {
        m_Material[1].color = hash[m[0].ToString()];
        m_Material[2].color = hash[m[1].ToString()];
        m_Material[3].color = hash[m[2].ToString()];
        for (int i = 3; i < m.Length; i++)
        {
            if (m[i] == '0')
            {
                num++;
            }
        }

        if (num > 0)
        {
            m_Material[4].color = hash[m[num].ToString()];
        }
    }

    void initializeColorBand()
    {

        hash.Add("0", Color.black);
        hash.Add("1", new Color(0.6320754f, 0.3201129f, 0));
        hash.Add("2", Color.red);
        hash.Add("3", new Color(1.0f, 0.64f, 0.0f));
        hash.Add("4", Color.yellow);
        hash.Add("5", Color.green);
        hash.Add("6", Color.blue);
        hash.Add("7", new Color(0.376f, 0.17f, 0.74f));
        hash.Add("8", Color.grey);
        hash.Add("9", Color.white);
    }
}
