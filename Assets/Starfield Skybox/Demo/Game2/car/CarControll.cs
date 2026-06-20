using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControll : MonoBehaviour
{
    GameObject Axis;
    float Speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Axis = GameObject.Find("axis");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = Axis.transform.position;
        Vector3 axis = new Vector3(0f, 1f, 0f);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(point, axis, 5*Speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.RotateAround(point, axis, -5*Speed);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(Speed >=0.2 && Speed <0.6)
                Speed += 0.1f / 10.0f;
            else if (Speed < 0.2  )
            Speed += 0.1f / 30.0f;
            

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Speed > -0.3)
                Speed -= 0.1f / 30.0f;
        }

        transform.Translate(0, 0, Speed);
        Speed *= 0.989f;
        //Debug.Log(Speed);

    }
}
