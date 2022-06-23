using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI機能を利用する際に必要なusing
using UnityEngine.UI;
// シーン遷移する際に必要なusing
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // テキストを変数で宣言
    public Text timeText;
    // 浮動小数点型変数timeを15秒で宣言する
    float time = 15;

    // Update is called once per frame
    void Update()
    {
        // 時間の計算
        time -= Time.deltaTime;
        // 計算した時間をUIへ「TIME：整数秒」形式で表示する
        timeText.text = "TIME：" + time.ToString("0");
        // もし制限時間がなくなったなら
        if(time <= 0)
        {
            // Goalシーンをロードする
            SceneManager.LoadScene("Goal");
        }
    }
}
