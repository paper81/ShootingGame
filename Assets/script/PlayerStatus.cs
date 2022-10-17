using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : ItemStatus
{
    [SerializeField]
    int bulletLevel;
    public int BulletLevel => bulletLevel;
    [SerializeField]
    int muzzleLevel;
    public int MuzzleLevel => muzzleLevel;
    [SerializeField]
    int maxHP;
    public int MaxHP => maxHP;
    [SerializeField]
    int subForceCount;
    public int SubForceCount => subForceCount;
    [SerializeField]
    float chargeTime;
    public float ChargeTime => chargeTime;

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
