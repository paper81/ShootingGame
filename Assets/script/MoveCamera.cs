using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    float scrollSpeed;
    [SerializeField]
    float[] stopPos, stopTime;

    int stopCount = 0;
    Vector3 pos;

    void Start()
    {
        pos = transform.position;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while(player != null)
        {
            yield return new WaitForEndOfFrame();
            if(transform.position.x > stopPos[stopCount])
            {
                if(stopTime[stopCount] == 0)
                {
                    stopTime[stopCount] = Mathf.Infinity;
                }
                yield return new WaitForSeconds(stopTime[stopCount]);
                stopCount++;
            }
            pos += scrollSpeed * Time.deltaTime * Vector3.right;
            transform.position = pos;
        }        
    }
}
