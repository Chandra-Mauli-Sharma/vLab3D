using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace ArrayStimulator
{
    class ArrayElement: MonoBehaviour{
        public int value;
        public GameObject Element;

        void Start(){
            Element=gameObject;
        }

        public ArrayElement(int value,GameObject element){
            this.value=value;
            this.Element=element;
            element.GetComponentInChildren<TMP_Text>().text=value.ToString();
        }
    }
}