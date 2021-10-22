using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        float Playermove = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.A))
        {
            Playermove = speed * Time.deltaTime; 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Playermove = -speed * Time.deltaTime;
        }

        this.transform.Translate(new Vector3(Playermove, 0, 0));
    }
}
