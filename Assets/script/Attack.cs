using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int attack;
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(target))
        {
            collision.gameObject.GetComponent<HP>().Damage(attack);
        }
    }
}
