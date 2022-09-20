using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCrab : MonoBehaviour
{
    public GameObject bullet;
    public float repeatTime;

    void Start()
    {
        InvokeRepeating(nameof(Shot), 0, repeatTime);
    }

    void Shot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
