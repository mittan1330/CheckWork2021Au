using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveManager : MonoBehaviour
{
    [SerializeField] GameObject road;
    [SerializeField] float roadLength = 66;
    [SerializeField] List<GameObject> roadList = new List<GameObject>();
    float distance = 0;


    // Start is called before the first frame update
    void Start()
    {
        distance = roadLength;
    }

    // Update is called once per frame
    void Update()
    {
        distance += 15 * Time.deltaTime;
        for (int i = 0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(Vector3.back * 15 * Time.deltaTime);

        }
        if (distance > roadLength)
        {
            Destroy(roadList[0]);
            roadList.RemoveAt(0);
            GameObject roadObj = Instantiate(road, new Vector3(0, 0, transform.position.z + 66 * 4), Quaternion.identity, this.transform);
            roadList.Add(roadObj);
            distance = 0;
        }

    }
}
