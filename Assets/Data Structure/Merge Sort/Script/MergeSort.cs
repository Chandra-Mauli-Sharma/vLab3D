using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayStimulator;

public class MergeSort : MonoBehaviour
{

    public GameObject arrayElement;

    
    // Start is called before the first frame update
    void Start()
    {
        ArrayElement[] ar=new ArrayElement[5];
        int[] p={2,10,56,6,4};
        for(int i=0;i<5;i++){
            ar[i]=new ArrayElement(p[i],Instantiate(arrayElement, new Vector3(i*2-2,0,0), Quaternion.identity));
        }

        sort(ar,0,4,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void merge(ArrayElement[] arr, int l, int m, int r,int level)
    {
        // Find sizes of two
        // subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;
 

        // Create temp arrays
        ArrayElement[] L = new ArrayElement[n1];
        ArrayElement[] R = new ArrayElement[n2];
        int i, j;
 
        // Copy data to temp arrays
        for (i = 0; i < n1; ++i){
            L[i]=new ArrayElement(arr[l + i].value,Instantiate(arrayElement, new Vector3(i*2-2,level,0), Quaternion.identity));
        }
            
        for (j = 0; j < n2; ++j,i++){
            R[j]=new ArrayElement(arr[m + 1 + j].value,Instantiate(arrayElement, new Vector3(i*2-2,level,0), Quaternion.identity));
        }
 
        // Merge the temp arrays
 
        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;
 
        // Initial index of merged
        // subarray array
        int k = l;
        while (i < n1 && j < n2) {
            if (L[i].value <= R[j].value) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
 
        // Copy remaining elements
        // of L[] if any
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }
 
        // Copy remaining elements
        // of R[] if any
        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
 
    // Main function that
    // sorts arr[l..r] using
    // merge()
    void sort(ArrayElement[] arr, int l, int r,int level)
    {
        if (l < r) {
            // Find the middle
            // point
            int m = l + (r - l) / 2;
 
            // Sort first and
            // second halves
            sort(arr, l, m,level+1);
            sort(arr, m + 1, r,level+1);
 
            // Merge the sorted halves
            merge(arr, l, m, r,level+1);
        }
    }
}
