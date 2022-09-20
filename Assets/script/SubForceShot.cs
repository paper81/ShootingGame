using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubForceShot : MonoBehaviour
{
    public GameObject bullet;
    public float directionTime;
    float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if(Input.GetButtonDown("ShotButton") && time > directionTime)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            time = 0;
        }
    }

    public void BulletUpGrade(GameObject bullet)
    {
        this.bullet = bullet;
    }
}
