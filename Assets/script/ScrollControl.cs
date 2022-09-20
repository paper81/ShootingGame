using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControl : MonoBehaviour
{
    public GameObject MainCamera, Player;
    public float scrollSpeed;
    public float[] stopPos, stopTime;

    void Start()
    {
        MainCamera.GetComponent<GameScroll>().scrollSpeed = scrollSpeed;
        MainCamera.GetComponent<GameScroll>().SetStop(stopPos, stopTime);
        Player.GetComponent<GameScroll>().SetStop(stopPos, stopTime);
        Player.GetComponent<GameScroll>().scrollSpeed = scrollSpeed;
    }
}
