using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScroll : MonoBehaviour
{
    [HideInInspector]public float scrollSpeed;
    int stopCount = 0;
    float[] stopPos, stopTime;
    float time, speed;
    protected Vector3 pos;

    protected virtual void Start()
    {
        speed = scrollSpeed;
    }

    protected Vector3 Scroll()
    {
        StopScroll();
        pos = scrollSpeed * Time.deltaTime * Vector3.right;
        return pos;
    }

    void StopScroll()
    {
        if (transform.position.x > stopPos[stopCount])
        {
            scrollSpeed = 0;
            time += Time.deltaTime;
            if (time > stopTime[stopCount])
            {
                stopCount += stopCount >= stopPos.Length -1 ? 0 : 1;
                time = 0;
                scrollSpeed = speed;
            }
        }
    }
    public void SetStop(float[] StopPos, float[] StopTime)
    {
        stopPos = StopPos;
        stopTime = StopTime;
    }
}
