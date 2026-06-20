using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        Pos = new Vector3(-2.729f, 4.236f, 3.752f);
        transform.position = Pos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-2.729f, 4.236f, 3.752f);
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            Pos = Input.mousePosition;
            if ((Pos.x > 300 && Pos.x < 410) && (Pos.y > 15 && Pos.y < 105))
            {
                transform.position = new Vector3(-2.573f, 4.236f, 3.701f);//파랑선택
                Debug.Log("파랑");
            }
            if ((Pos.x > 505 && Pos.x < 615) && (Pos.y > 10 && Pos.y < 100))
            {
                transform.position = new Vector3(-2.280f, 4.236f, 3.606f);//빨강선택
                Debug.Log("빨강");
            }
            if ((Pos.x > 730 && Pos.x < 825) && (Pos.y > 10 && Pos.y < 105))
            {
                transform.position = new Vector3(-1.978f, 4.279f, 3.516f);//노랑선택
                Debug.Log("노랑");
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(-2.573f, 4.236f, 3.701f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(-2.280f, 4.236f, 3.606f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(-1.978f, 4.279f, 3.516f);
        }

    }
}
