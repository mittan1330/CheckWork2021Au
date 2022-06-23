using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// シーン遷移する際に必要なusing
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    // 車がJumpする際の力を決める
    public float JumpPower = 10;
    // プレイヤーのRigidbody
    Rigidbody rigidbody;
    // jump確認用のbool
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーを押した時の処理
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump確認用のboolを見てJump可能であれば
            //if (Jump可能か判定)
            {
                // Rigidbodyコンポーネントを取得する

                // その場でジャンプするコード

                // jump確認用のboolをJumpできない判定にする

            }
        }
    }

    /*private void Trigger形式で衝突した際に呼び出す関数
    {
        // もしtagで「"Hurdle"」が付いているゲームオブジェクトに当たったら
        if ()
        {
            // 「"Fail"」シーンをロードする
            SceneManager.LoadScene("Fail");
        }
    }*/

    /*private void Collision形式で衝突した際に呼び出す関数
    {
        // もし車が地面に着地したなら
        if()
        {
            // jump確認用のboolをジャンプ可能な判定にする
            
        }
    }*/
}
