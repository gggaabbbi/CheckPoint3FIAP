using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3 : MonoBehaviour
{

    void Start()
    {
     
    }

    
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            print("Collected");
        }
    }
}
