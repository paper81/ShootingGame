using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHP : HP
{
    public GameObject parent, rockDie;
    public Collider2D col;
    public float time;
    int count;
    List<GameObject> obj = new List<GameObject>();

    protected override void Start()
    {
        base.Start();
    }

    public override void Damage(int attack)
    {
        currentHP -= attack;
        if (currentHP < 0)
        {
            col.enabled = false;
            count = transform.parent.childCount;
            StartCoroutine(nameof(Die));
        }
    }

    IEnumerator Die()
    {
        for (int i = 0; i < count; i++)
        {
            transform.parent.transform.GetChild(0).GetComponent<RockDie>().Die();
            yield return new WaitForSeconds(time);
        }
    }
}
