using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnakeTail : MonoBehaviour
{
    public GameObject obj;
    public int spam;
    List<Vector2> vector2s = new List<Vector2>();

    void FixedUpdate()
    {
        vector2s.Add(obj.transform.position);
        transform.rotation = Quaternion.FromToRotation(Vector3.left, obj.transform.position - transform.position);

        if (vector2s.Count - spam >= 0)
        {
            transform.position = vector2s[vector2s.Count - spam];
        }
    }
}
