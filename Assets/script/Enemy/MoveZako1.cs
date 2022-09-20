using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZako1 : MoveSin
{
    public float moveSpeed;
    public float waitTime;

    protected override void Start()
    {
        base.Start();        
    }

    IEnumerator Move()
    {
        StartCoroutine(SinMove());
        while (true)
        {
            yield return null;
            pos.x -= moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MovePos"))
        {
            StartCoroutine(Move());
        }
    }
}
