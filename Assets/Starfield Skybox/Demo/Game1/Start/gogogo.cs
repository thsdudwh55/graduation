using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogogo : MonoBehaviour
{
    int go = 0;
    float delta1 = 0;
    GameObject expl;
    GameObject Rect, Circle;
    // Start is called before the first frame update
    void Start()
    {
        expl = GameObject.Find("explain");
        Rect = GameObject.Find("RectButton");
        Circle = GameObject.Find("CircleButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (go == 1)
        {
            if (transform.position.x > -1)
            {
                transform.Translate(0, -0.2f, 0);
            }
            else
            {
                delta1 = delta1 + Time.deltaTime;
                if (delta1 >= 1.0f)
                {
                    Destroy(gameObject);
                    expl.transform.position = new Vector3(-3, 6, 18);
                    Rect.GetComponent<Rectbutton>().GoGoR();
                    Circle.GetComponent<Circle>().GoGoC();
                }
            }
        }

    }
    public void Startgo()
    {
        go = 1;
    }
}