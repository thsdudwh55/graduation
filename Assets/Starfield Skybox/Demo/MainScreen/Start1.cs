using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start1 : MonoBehaviour
{
    private Button btn;
    private void Awake()
    {
        btn = GetComponent<Button>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        startbutton();
    }

    
    public void startbutton()
    {
        btn.onClick.AddListener(delegate
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("SelectGame");
        });
    }
}
