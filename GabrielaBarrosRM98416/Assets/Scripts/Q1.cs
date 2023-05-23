using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q1 : MonoBehaviour
{
    private Transform playerTrans;
    [SerializeField] private float velocity;

    private int coin = 0;
   
    void Start()
    {
        playerTrans = GetComponent<Transform>();
    }

    
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        playerTrans.Translate(new Vector3(moveX, moveY, 0) * velocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coin++;
        }

        if (coin >= 5)
        {
            print("Collected" + coin + "coins!");
        }

    }
}
