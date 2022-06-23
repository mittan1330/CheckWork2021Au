using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using~ シーン遷移に必要なコードを書く
// シーン遷移する際に必要なusing
using UnityEngine.SceneManagement;

public class ResultViewManager : MonoBehaviour
{
    void Update()
    {
        // もしスペースキーが押されたなら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Mainシーンへ遷移する
            SceneManager.LoadScene("Main");
        }
    }
}
