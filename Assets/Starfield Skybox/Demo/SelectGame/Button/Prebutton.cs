using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prebutton : MonoBehaviour
{
    GameObject game1;
    GameObject game2;
    GameObject game3;
    private Button btn;

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

        Nextbutton();
    }
    public void Nextbutton()
    {
        btn.onClick.AddListener(delegate
        {
            GetComponent<AudioSource>().Play();
            
            if (game1.transform.position.x <= 680.5 && game1.transform.position.x >= 376.5)
            {

                game3.transform.position = new Vector3(game1.transform.position.x, game1.transform.position.y, 0);
                game2.transform.position = new Vector3(game1.transform.position.x - 700, game1.transform.position.y, 0);
                game1.transform.position = new Vector3(game1.transform.position.x + 700, game1.transform.position.y, 0);
            }

            else if (game2.transform.position.x <= 680.5 && game2.transform.position.x >= 376.5)
            {
                game1.transform.position = new Vector3(game2.transform.position.x, game1.transform.position.y, 0);
                game3.transform.position = new Vector3(game2.transform.position.x - 700, game1.transform.position.y, 0);
                game2.transform.position = new Vector3(game2.transform.position.x + 700, game1.transform.position.y, 0);
            }
            else if (game3.transform.position.x <= 680.5 && game3.transform.position.x >= 376.5)
            {

                game2.transform.position = new Vector3(game3.transform.position.x, game1.transform.position.y, 0);
                game1.transform.position = new Vector3(game3.transform.position.x - 700, game1.transform.position.y, 0);
                game3.transform.position = new Vector3(game3.transform.position.x + 700, game1.transform.position.y, 0);
            }





        });

    }
}
