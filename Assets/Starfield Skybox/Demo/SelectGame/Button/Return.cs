using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    private Button btn;
    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        Returnbutton();
    }


    public void Returnbutton()
    {
        btn.onClick.AddListener(delegate
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Main");
        });
    }
}
