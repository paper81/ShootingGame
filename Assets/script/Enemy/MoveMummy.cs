using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMummy : MonoBehaviour
{
    public float moveTime, teleportDis;
    Vector2 pos, teleportPos;
    Rect teleportRange;
    private void Start()
    {
        pos = transform.position;
        teleportRange = new Rect(transform.position.x - teleportDis, transform.position.y - teleportDis, 
                                    transform.position.x + teleportDis, transform.position.y + teleportDis);
        InvokeRepeating(nameof(Teleport), 0, moveTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Teleport();
    }

    void Teleport()
    {
        teleportPos.x = Random.Range(teleportRange.x, teleportRange.width);
        teleportPos.y = Random.Range(teleportRange.y, teleportRange.height);
        transform.position = teleportPos;
    }
}
