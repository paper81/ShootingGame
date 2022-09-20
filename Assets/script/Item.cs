using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ItemStatus
{
    public ItemKinds itemKinds;
    GameObject Player;
    GameObject PlayerStatus;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerStatus = GameObject.FindGameObjectWithTag("PlayerStatus");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    public void StatusUP()
    {
        switch (itemKinds)
        {
            case ItemKinds.MaxHP:
                Player.GetComponent<PlayerHP>().MaxHP += 2;
                Player.GetComponent<PlayerHP>().SliderUpDate();
                break;
            case ItemKinds.CurrentHP:
                Player.GetComponent<PlayerHP>().Recovery(5);
                break;
            case ItemKinds.Bullet:
                PlayerStatus.GetComponent<PlayerStatus>().StatusUP(itemKinds);
                break;
            case ItemKinds.Muzzlu:
                PlayerStatus.GetComponent<PlayerStatus>().StatusUP(itemKinds);
                break;
            case ItemKinds.Charge:
                PlayerStatus.GetComponent<PlayerStatus>().StatusUP(itemKinds);
                break;
        }
    }
}
