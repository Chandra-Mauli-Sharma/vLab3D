using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphMaker : MonoBehaviour
{

    public GameObject pointer;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<100;i++){
            for(int j=0;j<100;j++)
            Instantiate(pointer,new Vector3(j,i*j,0),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
