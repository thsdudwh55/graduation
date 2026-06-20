using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCube : MonoBehaviour
{
    float wait;
    int col = 0;
    GameObject explain;
    GameObject Gener,Judge;
    float Speed;



    // Start is called before the first frame update
    void Start()
    {
        
        explain = GameObject.Find("explain");
        Gener = GameObject.Find("Generator");
        wait = explain.transform.position.x;
        Speed = Gener.GetComponent<Generator>().Speed;
        Judge = GameObject.Find("실패성공판단");
    }
    public void OnCollisionEnter(Collision other)
    {
        col = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float z = transform.eulerAngles.z;

            if (wait == -3)
            {
                if (col == 1)
                {
                    transform.Translate(0, 0, 0.2f);
                    if (transform.position.z > 12.5)
                    {
                        transform.Translate(0, 0, -0.2f);
                        GetComponent<Rigidbody>().isKinematic = false;
                        if (transform.position.y < -1.8)
                        {
                            //GetComponent<Rigidbody>().isKinematic = true;
                            transform.Translate(0, 0, 0.03f);
                        }
                    }
                }
                else if (z <= 90 && x > 4)
                {
                    Vector3 point = new Vector3(4.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z <= 180 && x > 3 && x < 4.1)
                {
                    Vector3 point = new Vector3(3.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z <= 270 && x > 2 && x < 3.1)
                {
                    Vector3 point = new Vector3(2.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z <= 360 && x > 1 && x < 2.1)
                {
                    Vector3 point = new Vector3(1.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z > 352 || z < 90)
                {
                    Vector3 point = new Vector3(0.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);

                }
                else if (z >= 90 && z < 180)
                {
                    Vector3 point = new Vector3(-0.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z >= 180 && z < 270)
                {
                    Vector3 point = new Vector3(-1.5f, 0.46f, 10.6f);
                    Vector3 axis = new Vector3(0f, 0f, 1f);
                    transform.RotateAround(point, axis, 90f * Time.deltaTime * Speed);
                }

                else if (z >= 270 && z < 360 && x < -1)
                {
                    transform.Translate(1.5f * Time.deltaTime, 0, 0);

                    if (transform.position.y < -0.5) //가만있을때
                    {
                    Judge.GetComponent<judge>().Fail();
                    Destroy(gameObject);
                    
                    }
                }
                if (transform.position.z > 12)
                {
                    if (x >= 1.2 || x <= -1.5)
                    {
                    Judge.GetComponent<judge>().Fail();
                    //Destroy(gameObject); //튕길때
                    }
                }

                if (transform.position.y < -7) Destroy(gameObject);

            }
        
    }


}
