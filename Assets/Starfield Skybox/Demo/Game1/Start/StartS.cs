using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartS : MonoBehaviour
{
    GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("StartR");
        
    }

    // Update is called once per frame
    void Update()
    {
        float Posit = Cube.transform.position.x;
        float Po = transform.position.z;

        if(Posit < 0.05 && Po< 10.226)
        {
            transform.Translate(0, -0.5f, 0);
           
        }
       
        
    }
}
