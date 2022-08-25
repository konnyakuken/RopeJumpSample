using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpChecker : MonoBehaviour
{
    //PlayerControllerの情報を持ってくる
    public PlayerController playerController;
    
    //ontriggerのセンサーにobjectが通過した時
    public void OnTriggerEnter(Collider other)
    {
        //当たったやつがRopeなら
        if (other.tag=="Rope"){
            //さらにプレイヤーがジャンプをしていない時
            if(playerController.isJumping == false){
                //衝撃提示装置を実行する!!
                Debug.Log("GameOver");
            }

        }
    }
}
