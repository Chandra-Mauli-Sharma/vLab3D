using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BST;
using TMPro;

public class BinarySearchTreeSimulation : MonoBehaviour
{
    public GameObject treeNode;
    
    BSTree bst=new BSTree();

    public GameObject parent;
    TreeNode presentParent { get; set; }
    public TMP_InputField value;

    public void AddNode(){
        bst.Add(bst.Root,new TreeNode(int.Parse(value.text.ToString()),Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity,parent.transform)));

        // parent=bst.Add().element;
        
        // if(presentParent!=null){
        //     presentParent = bst.Add(new TreeNode(value.text,Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity,presentParent.element.transform)));
        //     Debug.Log(presentParent.element.name);
        // } 
        // else presentParent = bst.Add(new TreeNode(value.text,Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity)));
        
    }
}
