using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossShot : MonoBehaviour
{
    public GameObject bullet;
    public float repeatTime;
    public int shotNum = 1;

    void Start()
    {
        InvokeRepeating(nameof(Shot), 0, repeatTime);
    }

    void Shot()
    {
        for (int i = 0; i < 4 * shotNum; i++)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, i * 90 + transform.rotation.eulerAngles.z));
        }
    }
}
