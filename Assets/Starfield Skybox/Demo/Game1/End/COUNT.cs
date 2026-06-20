using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class COUNT : MonoBehaviour
{
    GameObject Win, Fail, jud, judge, Light;
    int end;
    string[] win = { "성", "공", "한", " ", "횟", "수 : ","##" };
    string[] fail = { "실", "패", "한", " ", "횟", "수 : ", "##" };
    string JJ;
    float delta = 0;
    int con1=0;
    int con2 = 0;
    int con3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Win = GameObject.Find("성공횟수");
        Fail = GameObject.Find("실패횟수");
        jud = GameObject.Find("평가");
        judge = GameObject.Find("실패성공판단");
        Light = GameObject.Find("Directional Light");

    }

    // Update is called once per frame
    void Update()
    {
        end = judge.GetComponent<judge>().end; //실패한횟수
        win[win.Length-1] = (22 - end).ToString();
        fail[fail.Length-1] = end.ToString();
        if (end <= 3) JJ = "와~ 정말 잘했어요 +_+";
        else if (end > 3 && end < 6) JJ = "흠... 나름 잘했네요 *^-^*";
        else if (end >= 6 && end <= 9) JJ = "좀..노력하셔야겠어요 -_-;;";
        else if (end > 9) JJ = "게임 하셨나요??"; 

        if (Light.GetComponent<Light>().intensity == 0)
        {
            SlowTypeing(win,fail,JJ);
        }
          
    }
    public void SlowTypeing(string[] win, string[] fail, string Jud)
    {
        int i;
        delta += Time.deltaTime;

        for (i = 0; i < win.Length; i++)
        {
            if (delta >= 0.1 && con1 == i)
            {
                Win.GetComponent<Text>().text += win[i];
                delta = 0;
                con1++;
            }
        }
        for (i = 0; i < fail.Length; i++)
        {
            if (delta >= 0.1 && con2 == i)
            {
                Fail.GetComponent<Text>().text += fail[i];
                delta = 0;
                con2++;
            }
        }
        for (i = 0; i < Jud.Length; i++)
        {
            if (delta >= 0.1 && con3 == i)
            {
                jud.GetComponent<Text>().text += Jud[i];
                delta = 0;
                con3++;
            }
        }
    }
}
        
    

    

        //Win.GetComponent<Text>().text += win[0];
        // Win.GetComponent<Text>().text += win[1];
    

