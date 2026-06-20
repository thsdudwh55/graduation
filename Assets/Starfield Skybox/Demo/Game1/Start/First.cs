using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    float delta = 0;
    float delta1 = 0;
    GameObject expl;
    GameObject StartS, StartR, StartL;
    // Start is called before the first frame update
    void Start()
    {
        expl = GameObject.Find("explain");
        StartS = GameObject.Find("StartS");
        StartR = GameObject.Find("StartR");
        StartL = GameObject.Find("StartL");

    }

    // Update is called once per frame
    void Update()
    {
        delta = delta + Time.deltaTime;
        if(delta > 2)
        {
            if(transform.position.x > -3)
            transform.Translate(0, -0.2f, 0);
        }
        if(transform.position.x < -3)
        {
            delta1 = delta1 + Time.deltaTime;
            if(delta1 >= 1.5f)
            {
                Destroy(gameObject);
                expl.GetComponent<explanation>().GoGo();
                Destroy(StartS);
                Destroy(StartR);
                Destroy(StartL);


            }
        }
        
    }
}
