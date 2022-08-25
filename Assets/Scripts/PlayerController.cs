using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //ジャンプ中はtrueになる。地面についたらfalseになる
    public bool isJumping = false;

    //基本はplyerのジャンプに関するコードなので関係なし
    public float jumpPower = 5;
    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    //playerが地面に設置した時
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            GetComponent<Renderer>().material.color = Color.gray;
            //ジャンプ中ではないため、isJumping を falseにする
            isJumping = false;
        }
    }

}
