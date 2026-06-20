using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickParicle : MonoBehaviour
{
    GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        this.particle = GameObject.Find("MouseParticle");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           /* Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 Pos = ray.direction;
            */
             Vector3 Pos = Input.mousePosition;

             Pos.x = (Pos.x / Screen.width)*2 -1;
            Pos.y = (Pos.y / Screen.height);





            particle.transform.position = new Vector3(Pos.x, Pos.y,0);
            GetComponent<ParticleSystem>().Play(); //마우스 클릭하면 파티클 생성
            Debug.Log(Pos +"ㅁㅁㅁㅁㅁ+"+ Input.mousePosition);
        }
        
    }
}
