using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Star : MonoBehaviour
{
    GameObject shot;
    GameObject Cir;
    GameObject Rec;
    public int RectCount=0, CirCount=0;
    Collision a;
    public Material material2;
    // Start is called before the first frame update
    void Start()
    {
        shot = GameObject.Find("Generator");
        Cir = GameObject.Find("CircleButton");
        Rec = GameObject.Find("RectButton");
        material2.color = new Color(1f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionExit(Collision other)
    {
        material2.color = new Color(1f,0,0);
    }
        public void OnCollisionEnter(Collision other)
    {
        RectCount = Rec.GetComponent<Rectbutton>().Rectcount;
        CirCount = Cir.GetComponent<Circle>().Circount;


        if (CirCount >= 1)
        {
            Vector3 posit = shot.GetComponent<Generator>().shoot.transform.position;
            if (posit.z < 9 && posit.y < 1.1)
            {
                shot.GetComponent<Generator>().shoot.GetComponent<Shoot>().Shoot2();//스타버튼 충돌시 원막대슛!
                Cir.GetComponent<Circle>().Cir1();
                GetComponent<AudioSource>().Play();
                material2.color = new Color(100f/255, 0, 0);
            }

        }
        if (RectCount >= 1)
        {
            Vector3 posit2 = shot.GetComponent<Generator>().shoot2.transform.position;
            if (posit2.z < 9 && posit2.y < 1.1)
            {
                shot.GetComponent<Generator>().shoot2.GetComponent<Shoot>().Shoot2();//스타버튼 충돌시 사각막대슛!
                Rec.GetComponent<Rectbutton>().Rect1();
                GetComponent<AudioSource>().Play();
                material2.color = new Color(100f / 255, 0, 0);
            }

        }
    }


}
