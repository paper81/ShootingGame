using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyHP : HP
{
    ShotSnake shotSnake;

    protected override void Start()
    {
        base.Start();
        shotSnake = gameObject.GetComponent<ShotSnake>();
    }

    public override void Damage(int attack)
    {
        currentHP -= attack;
        if(currentHP <= 0)
        {
            shotSnake.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SnakeHome"))
        {
            Recovery();
        }
    }

    public void Recovery()
    {
        currentHP = MaxHP;
        shotSnake.enabled = true;
    }
}
