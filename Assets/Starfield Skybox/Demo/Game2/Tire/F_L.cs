using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_L : MonoBehaviour
{
    GameObject F_L_Axis;


    // Start is called before the first frame update
    void Start()
    {
        F_L_Axis = GameObject.Find("F_L");
    }

    // Update is called once per frame
    void Update()
    {
        float Angle = transform.eulerAngles.y;
        Vector3 Posit = F_L_Axis.transform.position;
        Vector3 axis = new Vector3(0f, 1f, 0f);

        Debug.Log(Angle);


        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Angle <= 45 || Angle >= 270)
            {
                transform.RotateAround(Posit, axis, 3);
            }

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Angle >= 315 || Angle <= 270)
            {
                transform.RotateAround(Posit, axis, -3);
            }
        }
        if (Angle < 0.5 || Angle > 358)
        {
            transform.RotateAround(Posit, axis, 0);
        }

        else if (Angle < 50 && Angle >= 0)
        {
            transform.RotateAround(Posit, axis, -1);
        }
        else if (Angle < 365 && Angle >= 270)
        {
            transform.RotateAround(Posit, axis, 1);
        }





    }
}
