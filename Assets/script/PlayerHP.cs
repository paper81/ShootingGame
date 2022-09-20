using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : HP
{
    public Slider slider;
    public PlayerStatus status;

    protected override void Start()
    {
        base.Start();
        MaxHP = status.MaxHP;
        SliderUpDate();
    }

    private void Update()
    {
        if(transform.position.y < -9.5f)
        {
            Damage(100000);
        }
    }

    public override void Damage(int attack)
    {
        currentHP -= attack;
        SliderUpDate();
        if (currentHP <= 0)
            StartCoroutine(DieProcess());
    }

    public void Recovery(int amount)
    {
        currentHP += amount;
        SliderUpDate();
    }

    public void SliderUpDate()
    {
        slider.value = (float)currentHP / MaxHP;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("wall"))
        {
            currentHP -= currentHP;
            slider.value = 0;
            StartCoroutine(DieProcess());
        }
    }
}
