using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingExplain : MonoBehaviour
{
    GameObject first;
    GameObject second;
    GameObject third;
    GameObject fourth;
    GameObject fifth;
    GameObject mollang;
    GameObject click;
    // Start is called before the first frame update
    void Start()
    {
        first = GameObject.Find("1번");
        second = GameObject.Find("2번");
        third = GameObject.Find("3번");
        fourth = GameObject.Find("4번");
        fifth = GameObject.Find("5번");
        mollang = GameObject.Find("멀랑이");
        click = GameObject.Find("클릭시시작");
    }

    // Update is called once per frame
    void Update()
    {
        if (mollang.transform.position.y < 3.2f)
        {
            if (first.transform.position.y > 4.067f) first.transform.Translate(0, -0.8f * Time.deltaTime, 0);
            else if (second.transform.position.y < 3.79396f) second.transform.Translate(0, 1.8f * Time.deltaTime, 0);
            else if (third.transform.position.y < 3.58183f) third.transform.Translate(0, 1.6f * Time.deltaTime, 0);

            else if (fourth.transform.position.y < 3.243105f) fourth.transform.Translate(0, 0.8f * Time.deltaTime, 0);
            else if (fifth.transform.position.y < 3.024298f) fifth.transform.Translate(0, 0.8f * Time.deltaTime, 0);
            else if (click.transform.position.x > -0.47f) click.transform.Translate(-0.8f * Time.deltaTime, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(first);
            Destroy(second);
            Destroy(third);
            Destroy(fourth);
            Destroy(fifth);
            Destroy(click);
        }
    }
}
