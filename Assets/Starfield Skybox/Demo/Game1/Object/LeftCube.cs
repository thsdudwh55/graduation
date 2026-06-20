using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCube : MonoBehaviour
{
    float wait;
    int col = 0;
    GameObject explain, Gener,Judge;
    GameObject C1, C2, C3, C4, C5;

    int count = 0;
    int count1 = 0;
    float Speed;
    public int fail = 0;
    public int Starting = 0;
    // Start is called before the first frame update
    void Start()
    {
        C1 = GameObject.Find("do");
        C2 = GameObject.Find("re");
        C3 = GameObject.Find("mi");
        C4 = GameObject.Find("fa");
        C5 = GameObject.Find("sol");
        explain = GameObject.Find("explain");
        Gener = GameObject.Find("Generator");
        Judge = GameObject.Find("실패성공판단");

        wait = explain.transform.position.x;
        Speed = Gener.GetComponent<Generator>().Speed;

    }
    public void OnCollisionEnter(Collision other)
    {
        if (transform.position.x > -0.5)
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
                        transform.Translate(0, 0, 0.03f);
                        if (count1 == 0 )
                        {
                            Judge.GetComponent<judge>().Staring();
                            count1++;
                        }

                    }
                }
            }
            else if (z >= 270 && x < -4 && x >= -5)
            {
                Vector3 point = new Vector3(-4.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

                if (transform.position.x > -4.3)
                {
                    if (count == 0)
                    {
                        count += 1;
                        C1.GetComponent<C1>().Do();
                    }

                }
            }

            else if (z >= 180 && x < -3 && x >= -4.1)
            {

                Vector3 point = new Vector3(-3.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

                if (transform.position.x > -3.3)
                {
                    if (count == 1)
                    {
                        count += 1;
                        C2.GetComponent<C1>().Do();
                    }
                }

            }

            else if (z >= 90 && x < -2 && x >= -3.1)
            {
                Vector3 point = new Vector3(-2.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

                if (transform.position.x > -2.3)
                {
                    if (count == 2)
                    {
                        count += 1;
                        C3.GetComponent<C1>().Do();
                    }
                }
            }

            else if (z >= 0 && x <= -1 && x >= -2.1)
            {
                Vector3 point = new Vector3(-1.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

                if (transform.position.x > -1.3)
                {
                    if (count == 3)
                    {
                        count += 1;
                        C4.GetComponent<C1>().Do();
                    }
                }
            }


            else if (z >= 270 || z < 8)    //5
            {

                Vector3 point = new Vector3(-0.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);

                if (transform.position.x > -0.3)
                {
                    if (count == 4)
                    {
                        count += 1;
                        C5.GetComponent<C1>().Do();
                    }
                }


            }

            else if (z > 180 && z < 270)
            {
                Vector3 point = new Vector3(0.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);
            }

            else if (z > 92 && z < 180)
            {
                Vector3 point = new Vector3(1.5f, 0.46f, 10.39f);
                Vector3 axis = new Vector3(0f, 0f, 1f);
                transform.RotateAround(point, axis, -90f * Time.deltaTime * Speed);
            }

            else if (z > 0 && z < 92 && x > 1)
            {
                transform.Translate(-2f * Time.deltaTime, 0, 0);

                if (transform.position.y < -0.5) //가만있을때
                {
                    Judge.GetComponent<judge>().Fail();
                    Destroy(gameObject);
                }
            }
            if (transform.position.z > 12) //튕겨져 나갈때
            {
                if (x >= 1.2 || x <= -1.5)
                {
                    Judge.GetComponent<judge>().Fail();
                    //Destroy(gameObject);
                    
                }
            }
            if (transform.position.y < -7) //맵끝으로 갈때
            {
                Destroy(gameObject);
            }

        }
    }
}
    
    

