using TMPro;
using UnityEngine;

namespace BST
{
    class TreeNode: MonoBehaviour
    {
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
        public int Data { get; set; }

        public GameObject element;

        void Start(){
            element=gameObject;
        }

        public TreeNode()
        {
            
        }

        public TreeNode(int value,GameObject element)
        {
            this.Data = value;
            this.element=element;
            element.GetComponentInChildren<TMP_Text>().text=value.ToString();
        }

    }
}

