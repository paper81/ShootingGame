using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : GameScroll
{
    [SerializeField]
    GameObject player;
    protected override void Start()
    {
        base.Start();
        pos = transform.position;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while(player != null)
        {
            yield return new WaitForEndOfFrame();
            pos += Scroll();
            transform.position = pos;
        }
        
    }

    //void Update()
    //{
    //    pos += Scroll();
    //    transform.position = pos;        
    //}
}
