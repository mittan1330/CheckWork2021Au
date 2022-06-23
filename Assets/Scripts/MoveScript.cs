using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // ゲームオブジェクトの進む速さを指定する
    [SerializeField] float moveSpeed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        // ゲームオブジェクトが後ろへ進み車が前に進むように見える為のコード
        this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
