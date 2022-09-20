using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCross : MonoBehaviour
{
    public float repeatTime;
    Vector3 rotation;

    private void Start()
    {
        rotation = transform.rotation.eulerAngles;
        InvokeRepeating(nameof(Move), 0, repeatTime);
    }

    void Move()
    {
        rotation.z += 45;
        transform.eulerAngles = rotation;
    }
}
