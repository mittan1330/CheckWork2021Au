using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// シーン遷移する際に必要なusing
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    // 車がJumpする際の力を決める
    public float jumpPower = 10;
    // プレイヤーのRigidbody
    Rigidbody rigidbody;
    // jump確認用のbool
    bool canJump = true;

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
            if (canJump == true)
            {
                // Rigidbodyコンポーネントを取得する
                rigidbody = GetComponent<Rigidbody>();
                // その場でジャンプするコード
                rigidbody.velocity = new Vector3(0, jumpPower, 0);
                // jump確認用のboolをJumpできない判定にする
                canJump = false;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        // もしtagで「"Hurdle"」が付いているゲームオブジェクトに当たったら
        if (collision.gameObject.tag == "Hurdle")
        {
            // 「"Fail"」シーンをロードする
            SceneManager.LoadScene("Fail");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // もし車が地面に着地したなら
        if(collision.gameObject.tag == "Road")
        {
            // jump確認用のboolをジャンプ可能な判定にする
            canJump = true;
        }
    }
}
