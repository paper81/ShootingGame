using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEye : MonoBehaviour
{
    public float repeatTime;
    public GameObject enemyBullet;
    void Start()
    {
        InvokeRepeating(nameof(Shot), 0, repeatTime);
    }

    void Shot()
    {
        Instantiate(enemyBullet, transform.position, Quaternion.identity);
    }
}
