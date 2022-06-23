using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 道用のゲームオブジェクトを永遠に後進させ、車が前進している様に表現するスクリプト
/// </summary>
public class RoadMoveManager : MonoBehaviour
{
    // 生成する道を指定する為の変数
    [SerializeField] GameObject road;
    // roadゲームオブジェクトの縦の長さを指定する
    [SerializeField] float roadLength = 66;
    // 表示するroadゲームオブジェクトを格納するList
    [SerializeField] List<GameObject> roadList = new List<GameObject>();
    // 後進したroadゲームオブジェクトの残り長さを代入する変数
    float distance = 0;
    // roadゲームオブジェクトの後進速度を指定する
    [SerializeField] float moveSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 初期の生成位置を指定する
        distance = roadLength;
    }

    // Update is called once per frame
    void Update()
    {
        // 後進した長さを計算する
        distance += moveSpeed * Time.deltaTime;
        // Listへ格納されているroadゲームオブジェクト全てを後進させる
        for (int i = 0; i < roadList.Count; i++)
        {
            // roadゲームオブジェクトを後進させる
            roadList[i].transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        // もし経過した距離が道の長さよりも大きくなったら、新しいroadゲームオブジェクトを生成
        if (distance > roadLength)
        {
            // 後ろへ下がり切ったroadゲームオブジェクトを削除
            Destroy(roadList[0]);
            // 後ろへ下がり切ったroadゲームオブジェクトをListから削除
            roadList.RemoveAt(0);
            // 新しいroadゲームオブジェクトを生成
            GameObject roadObj = Instantiate(road, new Vector3(0, 0, transform.position.z + roadLength * 4), Quaternion.identity, this.transform);
            // 新しいroadゲームオブジェクトをListへ追加
            roadList.Add(roadObj);
            // 後進で経過した距離を初期化する
            distance = 0;
        }

    }
}
