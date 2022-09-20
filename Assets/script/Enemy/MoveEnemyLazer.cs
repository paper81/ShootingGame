using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyLazer : MoveLazer
{
    bool Isturn = false;
    bool IsUp;
    float turnTime;
    float time = 0;

    private void Start()
    {
        turnTime = Random.Range(0.25f, 1.25f);
        IsUp = Random.Range(0, 2) == 0;
        speedX = -speed;
        pos = transform.position;
        Destroy(this.gameObject, 3);
    }

    protected override void Update()
    {
        base.Update();
        time += Time.deltaTime;
        if (time > turnTime && Isturn == false)
        {
            speedX = 0;
            speedY = IsUp ? speed : -speed;
        }
    }
}
