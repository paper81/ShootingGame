using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEnemy : ItemStatus
{
    public GameObject MaxHP, CurrentHP, Bullet, Muzzle, Charge;
    public ItemKinds itemKinds;
    
    GameObject item;

    public GameObject SetItem()
    {
        switch (itemKinds)
        {
            case ItemKinds.MaxHP:
                item = MaxHP;
                break;
            case ItemKinds.CurrentHP:
                item = CurrentHP;
                break;
            case ItemKinds.Bullet:
                item = Bullet;
                break;
            case ItemKinds.Muzzlu:
                item = Muzzle;
                break;
            case ItemKinds.Charge:
                item = Charge; 
                break;
            default:
                item = null;
                break;
        }
        return item;
    }
}
