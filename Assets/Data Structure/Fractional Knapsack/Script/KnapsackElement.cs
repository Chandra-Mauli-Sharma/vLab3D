using UnityEngine;
using TMPro;


namespace Knapsack
{
    public class KnapsackElement : MonoBehaviour
    {
        public int value;
        public int weight;

        public GameObject Element;

        void onStart(){
            Element=gameObject;
        }

        public KnapsackElement(int value, int weight,GameObject Element)
        {
            this.value = value;
            this.weight = weight;
            this.Element=Element;
            Element.GetComponentsInChildren<TMP_Text>()[0].text=value.ToString();
            Element.GetComponentsInChildren<TMP_Text>()[1].text=weight.ToString();
        }
    }
}

