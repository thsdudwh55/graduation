using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartR : MonoBehaviour
{
    float Speed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float z = transform.eulerAngles.z;

        if (z <= 90 && x > 2 && x < 3.2)
        {
            Vector3 point = new Vector3(2.5f, 0.46f, 10.6f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
        }

        else if (z <= 180 && x > 0.8 && x < 2.1)
        {
            Vector3 point = new Vector3(1.5f, 0.46f, 10.6f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
        }

        else if (z > 180 && z < 270 )
        {
            Vector3 point = new Vector3(0.5f, 0.46f, 10.6f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);

        }
    }
}
