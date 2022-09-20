using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBullet_AutoAim : MonoBehaviour
{
    public float speed;
    GameObject target;
    public Rigidbody2D rb;
    void Start()
    {
        if (target = GameObject.FindGameObjectWithTag("Player"))
        {
            rb.AddForce((target.transform.position - transform.position).normalized * speed, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(Vector2.left.normalized * speed, ForceMode2D.Impulse);
        }
    }
}
