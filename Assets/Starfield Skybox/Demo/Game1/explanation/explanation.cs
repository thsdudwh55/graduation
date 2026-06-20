using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explanation : MonoBehaviour
{
    int Go = 0;
    int count = 0;
   
    GameObject Light, Ready;
    // Start is called before the first frame update
    void Start()
    {
        Light = GameObject.Find("Directional Light");
        Ready = GameObject.Find("준비");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Go == 1)
        {
            
            if (transform.position.y > 5.74f)
                transform.Translate(0, -3f * Time.deltaTime, 0);

            if (Input.GetMouseButtonDown(0))
            {
                Light.GetComponent<Light>().intensity = 1f;
                transform.position = new Vector3(3.9f, -6.3f, 21);
                if (count == 0)
                {
                    Ready.GetComponent<Ready>().Ready1();
                    count++;
                    Go = 0;
                }

            }
        }
        
    }
    public void GoGo()
    {
        Go = 1;
        Light.GetComponent<Light>().intensity = 0.2f;
    }
  
}
