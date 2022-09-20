using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBossArm : MonoBehaviour
{
    public float speed;
    public float waitTime;
    float posY;
    bool IsDown;
    Vector2 pos;

    void Start()
    {
        pos = transform.localPosition;
        speed = pos.y > 0 ? -speed : speed;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while (true)
        {
            yield return null;
            pos.y += speed * Time.deltaTime;
            transform.localPosition = pos;
            posY = Mathf.Abs(transform.localPosition.y);
            if ((posY < 1 && IsDown == false) || (posY > 1.5f && IsDown == true))
            {
                yield return new WaitForSeconds(waitTime);
                IsDown = !IsDown;
                speed *= -1;
            }
        }
    }
}
