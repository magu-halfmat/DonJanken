using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //最初メモ
    //まず右に走り出し、敵にあたったらジャンケンをする
    //勝ったら相手が落ちて自分は右に走る
    //一定のところまで行ったら勝ち


    float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //右に動く
        this.transform.Translate(speed, 0, 0);
    }
}
