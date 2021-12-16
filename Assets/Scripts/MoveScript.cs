using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 車で前に進むコード
        this.transform.Translate(Vector3.back * 15 * Time.deltaTime);
        // ここまで
    }
}
