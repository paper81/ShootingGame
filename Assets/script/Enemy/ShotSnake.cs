using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSnake : MonoBehaviour
{
    public GameObject bullet;
    public float waitTime, repeatTime;

    void Start()
    {
        StartCoroutine(Shot());
    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(waitTime);
        while (true)
        {
            yield return new WaitForSeconds(repeatTime);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
