using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyToHit : BulletDestroy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
