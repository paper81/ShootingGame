using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRock : MonoBehaviour
{
    public float rotationSpeed;
    Vector3 rotation;

    private void Start()
    {
        rotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        rotation.z = rotationSpeed;
        transform.Rotate(rotation);
    }

}
