using UnityEngine;

namespace BST
{
    class TreeNode: MonoBehaviour
    {
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
        public string Data { get; set; }

        public GameObject element;

        void Start(){
            element=gameObject;
        }

        public TreeNode()
        {
            
        }

        public TreeNode(string value,GameObject element)
        {
            this.Data = value;
            this.element=element;
        }

    }
}

