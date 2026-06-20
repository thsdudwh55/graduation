using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmera : MonoBehaviour
{
    GameObject car2;
    GameObject Carme;
    // Start is called before the first frame update
    void Start()
    {
        car2 = GameObject.Find("car2");
        Carme = GameObject.Find("Carme");

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 Posit = Carme.transform.position;
        Quaternion angle = Carme.transform.rotation;
        //angle.x = angle.x + 0.15f;
       // Debug.Log(angle.x); 

        transform.position = Posit;
        transform.rotation = angle;
       

        
    }
}
