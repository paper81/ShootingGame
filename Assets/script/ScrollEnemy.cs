using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEnemy : MonoBehaviour
{
    public float scrollSpeed;
    Vector2 pos;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        pos.x += scrollSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
