using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    GameObject explain;
    // Start is called before the first frame update
    void Start()
    {
        explain = GameObject.Find("explain");

    }

    // Update is called once per frame
    void Update()
    {
        if(explain.transform.position.y < 5.75f && transform.position.y > 3.196193f)
            transform.Translate(0.001f, 0.003283f, 0.00353f);
        if (Input.GetMouseButtonDown(0)) transform.position = new Vector3(-2.49f, 4.28f, 6.79f);

    }
        
}

