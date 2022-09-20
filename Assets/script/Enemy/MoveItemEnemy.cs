using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItemEnemy : ItemEnemy
{
    public float speed;
    float startPos, f;
    
    
    void Start()
    {
        Instantiate(SetItem(), new Vector2(transform.position.x, transform.position.y - 0.5f), Quaternion.identity).transform.SetParent(transform);
        startPos = transform.position.y;
        f = 1 / speed;
    }
    void Update()
    {
        SinMove();
    }

    void SinMove()
    {
        float sin = Mathf.Sin(2 * Mathf.PI * f * Time.time) + startPos;
        transform.position = new Vector2(transform.position.x, sin);
    }
    
}
