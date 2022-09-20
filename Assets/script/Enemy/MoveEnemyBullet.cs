using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
    }
}
