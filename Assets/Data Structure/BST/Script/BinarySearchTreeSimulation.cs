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

    void Start()
    {
        
        
        // var p=bst.Add(new TreeNode(50.ToString(),Instantiate(treeNode, new Vector3(0,0,0), Quaternion.identity)));
        // bst.Add(new TreeNode(50.ToString(),Instantiate(treeNode, new Vector3(2,-2,0), Quaternion.identity,p.element.transform)));
        // bst.Add(new TreeNode(50.ToString(),Instantiate(treeNode, new Vector3(-2,-2,0), Quaternion.identity,p.element.transform)));
        // tree.insert(30);
        // tree.insert(20);
        // tree.insert(40);
        // tree.insert(70);
        // tree.insert(60);
        // tree.insert(80);

    }


    public void AddNode(){

        parent=bst.Add(new TreeNode(value.text,Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity,parent.transform))).element;
        
        // if(presentParent!=null){
        //     presentParent = bst.Add(new TreeNode(value.text,Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity,presentParent.element.transform)));
        //     Debug.Log(presentParent.element.name);
        // } 
        // else presentParent = bst.Add(new TreeNode(value.text,Instantiate(treeNode, new Vector3(-3,0,0), Quaternion.identity)));
        
    }
    void Update()
    {

    }
}
