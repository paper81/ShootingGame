using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    GameObject Camera;
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if(transform.position.x < Camera.transform.position.x  -10f || transform.position.x > Camera.transform.position.x + 10.5f ||
                transform.position.y < Camera.transform.position.y -6.5f || transform.position.y > Camera.transform.position.y +6.5f)
        {
            Destroy(gameObject);
        }

    }
}
