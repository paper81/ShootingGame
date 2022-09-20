using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish : MonoBehaviour, IMoveEnemy
{
    public float speed;
    GameObject target;
    Vector2 pos, blowPos;

    void Start()
    {
        pos = transform.position;
    }

    void Blow()
    {
        transform.rotation = Quaternion.FromToRotation(Vector2.left, blowPos);
        pos.x += blowPos.x * speed * Time.deltaTime;
        pos.y += blowPos.y * speed * Time.deltaTime;
        transform.position = pos; 
    }

    IEnumerator Enumerator()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            Blow();
        }
    }

    public void Move()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        if (transform.position.x > target.transform.position.x)
        {
            blowPos = target.transform.position - transform.position;
            StartCoroutine(nameof(Enumerator));
        }
    }
}
