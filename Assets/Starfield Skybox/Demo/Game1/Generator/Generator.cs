using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject RightCoreCubePrefab;
    public GameObject LeftCoreCubePrefab;

    public GameObject RightRectCoreCubePrefab;
    public GameObject LeftRectCoreCubePrefab;

    public GameObject ShootPrefab;
    public GameObject RectShootPrefab;

    public GameObject rollerPrefab1;
    public GameObject rollerPrefab2;

    public GameObject shoot;
    public GameObject shoot2;

    public int type = 0;

    float[] speed = new float[24];
    public float Speed;

    float[] span = new float[23];      //+speed 추가 ,사각부품 젠시간
    float roller = 0.7f;
    float delta1 = 0;
    float delta2 = 0;
    int count = 0;
    public int shoottype = 0;

    int i = 0;  
    GameObject explain,Judge;
    float wait;
    int j;
    public GameObject right ;
    public GameObject left  ;



    // Start is called before the first frame update
    void Start()
    {
        explain = GameObject.Find("explain");
        Judge = GameObject.Find("실패성공판단");
        speed[0] = 1.5f; 
        speed[1] = 1.5f;
        speed[2] = 1.8f;

        speed[3] = 2.2f;
        speed[4] = 2.8f;
        speed[5] = 2.8f;
        speed[6] = 2.1f;
        speed[7] = 2.8f;

        speed[8] = 2.8f;
        speed[9] = 2.2f;
        speed[10] = 2.8f;

        speed[11] = 3.2f; 
        speed[12] = 3.2f;

        speed[13] = 1.8f;
        speed[14] = 2.2f;
        speed[15] = 1.5f + Random.Range(0, 3) * 0.7f;
        speed[16] = 2.3f;
        speed[17] = 1.5f + Random.Range(0, 3) * 0.7f;
        speed[18] = 2.5f;

        speed[19] = 3.5f; 
        speed[20] = 4.0f;

        speed[21] = 1.5f;
        speed[22] = 0;//없는값

        span[0] = 0.5f;
        span[21] = 4.0f;
        span[22] = 6.5f;
        for (j = 1; j < 21; j++)
        {
            span[j] = 7.07f / speed[j] + 1.285f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Speed = speed[i];
        wait = explain.transform.position.x;
        this.delta1 += Time.deltaTime;
        if (this.delta1 > this.roller)//바닥생성
        {
            this.delta1 = 0;
            GameObject roller1 = Instantiate(rollerPrefab1) as GameObject;
            GameObject roller2 = Instantiate(rollerPrefab2) as GameObject;
        }

        if (wait == -3)
        {
            this.delta2 += Time.deltaTime;

            if (this.delta2 > this.span[i])//사각부품생성
            {
                //Debug.Log(i + "    " + speed[i] + "     " + span[i]);
                this.delta2 = 0;
                if (i >= 22)
                {
                    Judge.GetComponent<judge>().End1();
                   // Debug.Log("게임끝    "+ i);
                }
                else
                {
                    type = Random.Range(1, 3);
                    if (type == 1)
                    {
                        i++;
                         right = Instantiate(RightCoreCubePrefab) as GameObject;
                         left = Instantiate(LeftCoreCubePrefab) as GameObject;
                    }
                    else//type = 2
                    {
                        i++;
                         right = Instantiate(RightRectCoreCubePrefab) as GameObject;
                         left = Instantiate(LeftRectCoreCubePrefab) as GameObject;
                    }
                }
            }
            if (count == 1)
            {
                shoot = Instantiate(ShootPrefab) as GameObject;
                count = 0;
                shoottype = 1;
            }
            if (count == 2)
            {
                shoot2 = Instantiate(RectShootPrefab) as GameObject;
                count = 0;
                shoottype = 2;
            }
            }

        }
    

   
    public void Gener()
    {
        count = 1;
        
    }
    public void Gener2()
    {
        count = 2;
        
    }



}

