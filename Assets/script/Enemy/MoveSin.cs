using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    public float speed, startTime;
    protected float f;
    protected Vector2 pos;

    protected virtual void Start()
    {
        pos = transform.position;
        f = 1 / speed;
    }

    protected IEnumerator SinMove()
    {
        while (true)
        {
            yield return null;
            float sin = Mathf.Sin(2 * Mathf.PI * f * Time.time + startTime) + pos.y;
            transform.position = new Vector2(pos.x, sin);
        }
    }
}
