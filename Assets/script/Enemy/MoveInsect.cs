using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInsect : MonoBehaviour, IMoveEnemy
{
    public float speed;
    [HideInInspector] public bool IsMove = false;

    public void Move()
    {
        IsMove = true;
    }

    void Update()
    {
        if (IsMove)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
