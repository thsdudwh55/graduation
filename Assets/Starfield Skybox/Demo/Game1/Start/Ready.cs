using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    int go = 0;
    float delta1 = 0;
    GameObject gogogo;
    // Start is called before the first frame update
    void Start()
    {
        gogogo = GameObject.Find("시작");
    }

    // Update is called once per frame
    void Update()
    {
        if (go == 1)
        {
            if (transform.position.x > -1)
            {
                transform.Translate(0, -0.2f, 0);
            }
            else
            {
                delta1 = delta1 + Time.deltaTime;
                if (delta1 >= 1.0f)
                {
                    Destroy(gameObject);
                    gogogo.GetComponent<gogogo>().Startgo();
                }
            }
        }
        
    }
    public void Ready1()
    {
        go = 1;
    }
}
