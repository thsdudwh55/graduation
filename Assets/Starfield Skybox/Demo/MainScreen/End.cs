using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class End : MonoBehaviour
{
    private Button btn;
    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        returnbutton();
    }
    public void returnbutton()
    {
        btn.onClick.AddListener(delegate
        {
            GetComponent<AudioSource>().Play();
            Application.Quit(0);//pc확인불가
            Debug.Log("게임종료");
           


        });

    }
}
