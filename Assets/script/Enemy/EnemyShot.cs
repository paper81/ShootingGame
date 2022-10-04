using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float repeatTime, shotNum, shotDir;
    public GameObject bullet, muzlle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MovePos"))
        {
            StartCoroutine(Shot());
        }
    }

    IEnumerator Shot()
    {
        while (true)
        {
            yield return new WaitForSeconds(repeatTime);
            for (int i = 0; i < shotNum; i++)
            {
                Instantiate(bullet, muzlle.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(shotDir);
            }
        }
    }
}
