using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZako2 : MonoBehaviour
{
    public float speed, turnPos;
    Vector2 pos;
    bool IsPosDown;
    public Transform target;

    void Start()
    {
        pos = transform.position;
        IsPosDown = pos.y < turnPos;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        speed *= IsPosDown == true ? 1 : -1;
        while ((transform.position.x - target.transform.position.x) > 5)
        {
            yield return null;
            if(target == null)
            {
                yield break;
            }
        }

        while ((transform.position.y > target.position.y && IsPosDown == false) ||
                                (transform.position.y < target.position.y && IsPosDown == true))
        {
            yield return null;
            MoveVertical();
                
        }

        speed *= IsPosDown == true ? -1 : 1;

        while (true)
        {
            yield return null;
            MoveSide();
        }
    }

    void MoveVertical()
    {
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
    }

    void MoveSide()
    {
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
}
