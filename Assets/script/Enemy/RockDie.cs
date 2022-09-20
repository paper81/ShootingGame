using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDie : MonoBehaviour
{
    public GameObject rock, dieEffect;
    GameObject parent;

    void Start()
    {
        parent = transform.parent.gameObject;
    }

    public void Die()
    {
        Instantiate(rock, transform.position, transform.rotation, parent.transform);
        Instantiate(dieEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
