using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        time -= Time.deltaTime;
        timeText.text = "TIME：" + time.ToString("0");
        if(time <= 0)
        {
            SceneManager.LoadScene("Goal");
        }
    }
}
