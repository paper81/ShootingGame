using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyLazerAim : MoveLazer
{
    Transform targetPos;
    bool IsTurn = false;

    void Start()
    {
        targetPos = GameObject.FindGameObjectWithTag("Player").transform;
        speedX = -speed;
        pos = transform.position;
        Destroy(this.gameObject, 3);
    }

    protected override void Update()
    {
        base.Update();
        if(targetPos.position.x > transform.position.x && IsTurn == false)
        {
            IsTurn = true;
            Turn();
        }
    }

    public void Turn()
    {
        speedX = 0;
        speedY = targetPos.position.y < transform.position.y ? -speed : speed;
    }
}
