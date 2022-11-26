using UnityEngine;
using TMPro;

namespace QueueStimulator
{
    public class QueueElement: MonoBehaviour
    {
        public string value;
        public GameObject element;

        void Start(){
            element=gameObject;
        }
        public QueueElement(string value,GameObject element)
        {
            this.value = value;
            this.element=element;
            element.GetComponentInChildren<TMP_Text>().text=value.ToString();
        }
    }
}
