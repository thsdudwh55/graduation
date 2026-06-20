using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackB : MonoBehaviour
{
    Button BackButton;
    private void Awake()
    {
        BackButton = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Backbutton1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Backbutton1()
    {
        BackButton.onClick.AddListener(delegate
        {
            SceneManager.LoadScene("SelectGame");
        });
    }
}
