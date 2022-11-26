using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;
using Knapsack;
using TMPro;

public class FractionalKnapsack : MonoBehaviour
{ 
    double totalVal = 0f;
    int currW = 0;
    int w;
    int j=0;
    int p=0;

    public TMP_InputField profit;

    public GameObject knapsackElement;

    public TMP_InputField weight;
    public TMP_InputField requiredWeight;

    List<KnapsackElement> items=new List<KnapsackElement>();
    bool flag=true;

    class cprCompare : IComparer<KnapsackElement> {
        public int Compare(KnapsackElement x, KnapsackElement y)
        {
            KnapsackElement item1 = (KnapsackElement)x;
            KnapsackElement item2 = (KnapsackElement)y;
            double cpr1 = (double)item1.value
                            / (double)item1.weight;
            double cpr2 = (double)item2.value
                            / (double)item2.weight;

            if (cpr1 < cpr2)
                return 1;

            return cpr1 > cpr2 ? -1 : 0;
        }
    }

    public void Add(){
        items.Add(new KnapsackElement(int.Parse(profit.text.ToString()),int.Parse(weight.text.ToString()), Instantiate(knapsackElement, new Vector3(-33.3f,8,21.0f)+j*new Vector3(0,-2,0), Quaternion.identity)));
        j++;
    }

    public void Sort(){
        cprCompare cmp = new cprCompare();
        items.Sort(cmp);
    }

    public void FracKnapSack()
    {
        w=int.Parse(requiredWeight.text.ToString());
        if (p<items.Count&&flag){
            var i=items[p++];
            var remaining = w - currW;

            // If the whole item can be
            // taken, take it
            if (i.weight <= remaining) {
                totalVal += (double)i.value;
                currW += i.weight;
            }

            // dd fraction until we run out of space
            else {
                if(remaining==0) flag=false;
                double fraction
                    = remaining / (double)i.weight;
                totalVal += fraction * (double)i.value;
                currW += (int)(fraction * (double)i.weight);
            }
        } else{
            Debug.Log(totalVal);
        }

    }
}
