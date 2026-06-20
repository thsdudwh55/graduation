using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartL : MonoBehaviour
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
     

 
        
        if (z >= 270 && x < -2 && x >= -3.1)
        {
            Vector3 point = new Vector3(-2.5f, 0.46f, 10.39f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

            
        }

        else if (z >= 180 && x <= -1 && x >= -2.1)
        {
            Vector3 point = new Vector3(-1.5f, 0.46f, 10.39f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

            
        }

        
        else if (z >= 90 )    //5
        {

            Vector3 point = new Vector3(-0.5f, 0.46f, 10.39f);
            Vector3 axis = new Vector3(0f, 0f, 1f);
            transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

            


        }

    }
}
