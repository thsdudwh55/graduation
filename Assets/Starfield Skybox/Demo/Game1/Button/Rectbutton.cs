using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectbutton : MonoBehaviour
{
    GameObject Gener;
    GameObject Cir;
    GameObject star;
    public int Rectcount = 0;
    int Circount = 0;
    int go = 0;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        Gener = GameObject.Find("Generator");
        Cir = GameObject.Find("CircleButton");
        star = GameObject.Find("StarButton");
        material.color = new Color(0,0,1);
    }
    // Update is called once per frame
    void Update()
    {
        Circount = Cir.GetComponent<Circle>().Circount;

    }
    public void OnCollisionExit(Collision other) { 
    material.color = new Color(0,0,1); }
    public void OnCollisionEnter(Collision other)
    {
        if (go == 1)
        {
            if (Rectcount == 0 && Circount == 0)
            {
                GetComponent<AudioSource>().Play();
                Gener.GetComponent<Generator>().Gener2();
                material.color = new Color(0f, 0f, 100f/255);
                Rectcount += 1;
            }
        }


    }
    public void Rect1()
    {
        Rectcount = 0;
    }
    public void GoGoR()
    {
        go = 1;
    }

}
