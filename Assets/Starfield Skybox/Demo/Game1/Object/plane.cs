using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(0, 0, 1 * Time.deltaTime);

        if (transform.position.z > 22.7) transform.Translate(-1 * Time.deltaTime,0,0);
        if (transform.position.z > 24) Destroy(gameObject);

    }
}
