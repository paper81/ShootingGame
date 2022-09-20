using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : GameScroll
{
    protected override void Start()
    {
        base.Start();
        pos = transform.position;
    }
    void Update()
    {
        pos += Scroll();
        transform.position = pos;
        
    }
}
