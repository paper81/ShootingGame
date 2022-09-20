using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int MaxHP;
    public uint effectCount;
    public float waitTime;
    public float effectRange;
    public GameObject DieEffectObj;
    public Collider2D boxcollider;
    Vector2 effectArea;
    protected int currentHP;
    bool IsDie = false;

    protected virtual void Start()
    {
        currentHP = MaxHP;
    }

    public virtual void Damage(int attack)
    {
        currentHP -= attack;

        if (currentHP <= 0 && IsDie == false)
        {
            IsDie = true;
            StartCoroutine(DieProcess());
        }
    }

    protected virtual IEnumerator DieProcess()
    {
        yield return InsEffect();
        Destroy(gameObject);
    }

    protected IEnumerator InsEffect()
    {
        effectArea = (Vector2)transform.position + boxcollider.offset;
        Vector2 insPos;
        for (int i = 0; i < effectCount; i++)
        {
            insPos.x = Random.Range(effectArea.x - effectRange, effectArea.x + effectRange);
            insPos.y = Random.Range(effectArea.y - effectRange, effectArea.y + effectRange);
            Instantiate(DieEffectObj, insPos, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}