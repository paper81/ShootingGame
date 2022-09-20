using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : ItemStatus
{
    public int bulletLevel, muzzleLevel, MaxHP, subForceCount;
    public float chargeTime;

    public GameObject[] subForce;

    public void StatusUP(ItemKinds itemKinds)
    {
        switch (itemKinds)
        {
            case ItemKinds.Bullet:
                bulletLevel++;
                break;
            case ItemKinds.Muzzlu:
                muzzleLevel++;
                break;
            case ItemKinds.Charge:
                chargeTime *= 0.02f;
                break;
            case ItemKinds.subForce:
                if(subForceCount < subForce.Length)
                {
                    subForceCount++;
                    subForce[subForceCount].SetActive(true);
                }                
                break;
        }
    }
}
