using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerBullet : MonoBehaviour
{
    public float speed;
    Vector2 pos;
    void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        pos.x += speed  * Time.deltaTime;
        transform.position = pos;
    }
}
