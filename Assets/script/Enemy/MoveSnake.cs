using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveSnake : MonoBehaviour
{
    public float moveTime;
    public Transform[] transforms;
    Vector3[] path;

    void Start()
    {
        GetPath();
        transform.DOLocalPath(path, moveTime, PathType.CatmullRom)
            .SetLookAt(0.05f, Vector2.right, Vector2.up)
            .SetEase(Ease.Linear);
    }

    void GetPath()
    {
        path = new Vector3[transforms.Length];

        for(int i = 0; i < transforms.Length; i++)
        {
            path[i] = transforms[i].position;
        }
    }
}
