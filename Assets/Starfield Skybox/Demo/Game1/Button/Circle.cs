using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    GameObject Gener;
    GameObject Rect;
    GameObject star;
    public int Circount = 0;
    int Rectcount = 0;
    int go = 0;
    public Material material3;

    // Start is called before the first frame update
    void Start()
    {
        Gener = GameObject.Find("Generator");
        Rect  = GameObject.Find("RectButton");
        star = GameObject.Find("StarButton");
        material3.color = new Color(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Rectcount = Rect.GetComponent<Rectbutton>().Rectcount;

    }
    public void OnCollisionExit(Collision other)
    {
        material3.color = new Color(1, 1, 0);
    }
        public void OnCollisionEnter(Collision other)
    {
        if (go == 1)
        {
            if (Circount == 0 && Rectcount == 0)
            {
                GetComponent<AudioSource>().Play();
                Gener.GetComponent<Generator>().Gener();
                Circount += 1;
                material3.color = new Color(100f / 255, 100f / 255, 0);
            }
        }

   
    }
    public void Cir1()
    {
        Circount = 0;
    }
    public void GoGoC()
    {
        go = 1;
    }
}
