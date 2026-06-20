using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judge : MonoBehaviour
{
    GameObject generator,Ending,explain,Light;
    GameObject Back,Canvas;


    int ShootType=0; //1은 원형 2는 사각형
    int CubeType=0;// 1은 원형 2는 사각형
    int fail=0,win = 0;
    int Starting = 0;
    int End = 0;  //임시 1 원래 0//////////////////////////////////////////////

    public int end = 0;


    // Start is called before the first frame update
    void Start()
    {
        generator = GameObject.Find("Generator");
        Ending = GameObject.Find("Ending");
        explain = GameObject.Find("explain");
        Light = GameObject.Find("Directional Light");
        Back = GameObject.Find("되돌아가기");
        Canvas = GameObject.Find("결과값");
        Back.gameObject.SetActive(false);
        Canvas.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Starting == 1)
        {
            if (fail == 0)
            {
                CubeType = generator.GetComponent<Generator>().type;
                ShootType = generator.GetComponent<Generator>().shoottype;
                if (ShootType == 1)
                {
                    Vector3 right = (generator.GetComponent<Generator>().right.transform.position);
                    Vector3 left = (generator.GetComponent<Generator>().left.transform.position);
                    Vector3 shoot = (generator.GetComponent<Generator>().shoot.transform.position);
                    if (ShootType == CubeType)
                    {
                        if ((right.x + left.x) / 2 - shoot.x >= -0.080f && (right.x + left.x) / 2 - shoot.x <= 0.080)
                        {
                            if ((right.y + left.y) / 2 - shoot.y >= -0.08 && (right.y + left.y) / 2 - shoot.y <= 0.080)
                            {
                                if ((right.z + left.z) / 2 - shoot.z >= -0.291 && (right.z + left.z) / 2 - shoot.z <= 0.568)
                                {
                                    win++;
                                    Debug.Log(win);
                                }
                            }
                        }
                    } 
                }
            else if (ShootType == 2)
            {
                        Vector3 right = (generator.GetComponent<Generator>().right.transform.position);
                        Vector3 left = (generator.GetComponent<Generator>().left.transform.position);
                        Vector3 shoot = (generator.GetComponent<Generator>().shoot2.transform.position);
                    if (ShootType == CubeType)
                    {
                        if ((right.x + left.x) / 2 - shoot.x >= -0.080 && (right.x + left.x) / 2 - shoot.x <= 0.080)
                        {
                            if ((right.y + left.y) / 2 - shoot.y >= -0.08 && (right.y + left.y) / 2 - shoot.y <= 0.080)
                            {
                                if ((right.z + left.z) / 2 - shoot.z >= -0.291 && (right.z + left.z) / 2 - shoot.z <= 0.568)
                                {
                                    win++;
                                    Debug.Log(win);
                                }
                            }
                        }
                    }
                    
                }
            }
        }
        Starting = 0;
        ShootType = 0;
        fail = 0;
        if(End == 1)
        {
            Light.GetComponent<Light>().intensity -= 0.01f;
            explain.GetComponent<AudioSource>().Stop();
            if (Light.GetComponent<Light>().intensity <= 0)
            {
                Back.gameObject.SetActive(true);
                Canvas.gameObject.SetActive(true);
                end = 22 - win;
            }
        }
    }
    public void Fail()
    {
        fail = 1;
    }
    public void Staring()
    {
        Starting = 1;
    }
    public void End1()
    {
        End = 1;
    }
    
}

