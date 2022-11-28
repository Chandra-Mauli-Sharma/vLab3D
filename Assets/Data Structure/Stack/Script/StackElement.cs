using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace StackStimulator
{
    public class StackElement: MonoBehaviour
    {
        public string value;
        public GameObject element;

        void Start(){
            element=gameObject;
        }
        public StackElement(string value,GameObject element)
        {
            this.value = value;
            this.element=element;
            element.GetComponentInChildren<TMP_Text>().text=value.ToString();
        }
    }
}
