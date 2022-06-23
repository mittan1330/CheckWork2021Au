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
        // 障害物を一定の速度でプレイヤー側へ進めるコード
        this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
