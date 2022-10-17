using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubForceShot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    float directionTime;

    void Start()
    {
        StartCoroutine(Shot());
    }

    IEnumerator Shot()
    {
        while (true)
        {
            yield return new WaitForSeconds(directionTime);
            yield return new WaitUntil(() => Input.GetButtonDown("ShotButton"));
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    public void BulletUpGrade(GameObject Bullet)
    {
        bullet = Bullet;
    }
}
