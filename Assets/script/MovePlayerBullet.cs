using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerBullet : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D rb2;

    void Start()
    {
        rb2.AddForce(transform.right * speed, ForceMode2D.Impulse);
    }
}
