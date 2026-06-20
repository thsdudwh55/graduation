using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    float wait;
    int col = 0;
    GameObject explain;
    GameObject gener;
    
    


    // Start is called before the first frame update
    void Start()
    {
        explain = GameObject.Find("explain");
        gener = GameObject.Find("Generator");
        wait = explain.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (wait == -3)
        {
            if (col == 1)
            {
                if (transform.position.y < 1.1 && transform.position.z > 10.2)
                {
                    transform.Translate(0, -0.1f, 0);
                    if (transform.position.z > 12.35)
                    {
                        transform.Translate(0, 0.1f, 0);

                        if (transform.position.y < -1.8)
                        {
                            transform.Translate(0, -0.03f, 0);

                            if (transform.position.z > 13) //성공했을때 네모부품사이에끼임
                            {
                                GetComponent<Rigidbody>().isKinematic = true;

                            }

                            if (transform.position.y < -2.38) //실패했을때 그냥 바닥에
                            {
                                GetComponent<Rigidbody>().isKinematic = true;
                            }

                        }
                    }
                }
            }

            //Shoot2();  //클릭시 슛!
            

            if (transform.position.z > 22.5)//맵밖으로 나가면 삭제
                {
                    if (transform.eulerAngles.x < 325)
                    {
                        transform.Rotate(45 * Time.deltaTime, 0, 0);
                    }


                }
                if (transform.position.y < -7) Destroy(gameObject);
                /*if(transform.position.y > 1.3 && transform.position.z > 12)
                {
                    Destroy(gameObject);
                }*/

            }
        }

    public void Shoot2()
    {
        col = 1;
        transform.Translate(0, -5f, 0);
    }
}

