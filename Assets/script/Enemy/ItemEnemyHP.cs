using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEnemyHP : HP
{
    public ItemEnemy itemEnemy;

    public override void Damage(int attack)
    {
        currentHP -= attack;
        if (currentHP < 0)
        {
            ItemDrop();
            Destroy(gameObject);
        }
    }
    void ItemDrop()
    {
        if(transform.childCount != 0)
        {
            var obj = Instantiate(itemEnemy.SetItem(), new Vector2(transform.position.x, transform.position.y - 0.5f), Quaternion.identity);
            obj.GetComponent<Animator>().SetTrigger("Trigger");
        }
    }
}
