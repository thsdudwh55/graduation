using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectGame : MonoBehaviour
{
    private Button btn;
    GameObject game1;
    GameObject game2;
    GameObject game3;

    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.game1 = GameObject.Find("Game1");
        this.game2 = GameObject.Find("Game2");
        this.game3 = GameObject.Find("Game3");

        Selectbutton();
    }


    public void Selectbutton()
    {
        btn.onClick.AddListener(delegate
        {
            GetComponent<AudioSource>().Play();
            Debug.Log(game1.transform.position.x);
            if (game1.transform.position.x <= 680.5 && game1.transform.position.x >= 300.5)
            {
                Debug.Log("노랑 게임 선택");
                SceneManager.LoadScene("Game1");

            }

            else if (game2.transform.position.x <= 680.5 && game2.transform.position.x >= 300.5)
            {
                Debug.Log("파랑 게임 선택");

            }
            else if (game3.transform.position.x <= 680.5 && game3.transform.position.x >= 300.5)
            {
                Debug.Log("빨강 게임 선택");

            }

        });
    }
}
