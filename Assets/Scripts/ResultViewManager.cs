using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using~ シーン遷移に必要なコードを書く
using UnityEngine.SceneManagement;

public class ResultViewManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
