using System;
using BST;

class BSTree
{
    public TreeNode Root { get; set; }

    public BSTree(){
        Root=null;
    }
 
    public TreeNode Add(TreeNode root,TreeNode node)
    {

        if(root==null){
            root=node;
            return root;
        }

        if(node.Data<Root.Data)
            Root.LeftNode=Add(root.LeftNode,node);
        else if(node.Data>Root.Data)
            Root.RightNode=Add(root.RightNode,node);
 
        return root;
    }
 
    // public TreeNode Find(int value)
    // {
    //     return this.Find(value, this.Root);            
    // }
 
    // public void Remove(int value)
    // {
    //     this.Root = Remove(this.Root, value);
    // }
 
    // private TreeNode Remove(TreeNode parent, int key)
    // {
    //     if (parent == null) return parent;
 
    //     if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key); else if (key > parent.Data)
    //         parent.RightNode = Remove(parent.RightNode, key);
 
    //     // if value is same as parent's value, then this is the TreeNode to be deleted  
    //     else
    //     {
    //         // TreeNode with only one child or no child  
    //         if (parent.LeftNode == null)
    //             return parent.RightNode;
    //         else if (parent.RightNode == null)
    //             return parent.LeftNode;
 
    //         // TreeNode with two children: Get the inorder successor (smallest in the right subtree)  
    //         parent.Data = MinValue(parent.RightNode);
 
    //         // Delete the inorder successor  
    //         parent.RightNode = Remove(parent.RightNode, parent.Data);
    //     }
 
    //     return parent;
    // }
 
    // private int MinValue(TreeNode TreeNode)
    // {
    //     int minv = TreeNode.Data;
 
    //     while (TreeNode.LeftNode != null)
    //     {
    //         minv = TreeNode.LeftNode.Data;
    //         TreeNode = TreeNode.LeftNode;
    //     }
 
    //     return minv;
    // }
 
    // private TreeNode Find(int value, TreeNode parent)
    // {
    //     if (parent != null)
    //     {
    //         if (value == parent.Data) return parent;
    //         if (value < parent.Data)
    //             return Find(value, parent.LeftNode);
    //         else
    //             return Find(value, parent.RightNode);
    //     }
 
    //     return null;
    // }
 
    public int GetTreeDepth()
    {
        return this.GetTreeDepth(this.Root);
    }
 
    private int GetTreeDepth(TreeNode parent)
    {
        return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
    }
 
    public void TraversePreOrder(TreeNode parent)
    {
        if (parent != null)
        {
            TraversePreOrder(parent.LeftNode);
            TraversePreOrder(parent.RightNode);
        }
    }
 
    public void TraverseInOrder(TreeNode parent)
    {
        if (parent != null)
        {
            TraverseInOrder(parent.LeftNode);
            TraverseInOrder(parent.RightNode);
        }
    }
 
    public void TraversePostOrder(TreeNode parent)
    {
        if (parent != null)
        {
            TraversePostOrder(parent.LeftNode);
            TraversePostOrder(parent.RightNode);
        }
    }
}