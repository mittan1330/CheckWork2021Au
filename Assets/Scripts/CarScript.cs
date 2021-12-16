using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public float jumpPower = 10;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // コンポーネントを取得する
        rigidbody = GetComponent<Rigidbody>();
        // ここまで
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーを押した時の処理
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // その場でジャンプするコード
            rigidbody.velocity = new Vector3(0, jumpPower, 0);
        }
        // ここまで
    }


    private void OnTriggerEnter(Collider collision)
    {
        // もしtag「"Hurdle"」に当たったら「"Fail"」シーンをロードする
        if (collision.gameObject.tag == "Hurdle")
        {
            SceneManager.LoadScene("Fail");
        }
        // ここまで
    }

}
