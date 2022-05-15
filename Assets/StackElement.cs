using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StackStimulator
{
    public class StackElement: MonoBehaviour
    {
        public float value;
        public GameObject element;

        void Start(){
            element=gameObject;
        }
        public StackElement(float value,GameObject element)
        {
            this.value = value;
            this.element=element;
        }
    }
}
