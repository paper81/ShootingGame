using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : HP
{
    [SerializeField]
    Slider slider;
    [SerializeField]
    PlayerStatus status;
    [SerializeField]
    Image gameOverImage;

    protected override void Start()
    {
        base.Start();
        MaxHP = status.MaxHP;
        SliderUpDate();
    }

    public override void Damage(int attack)
    {
        currentHP -= attack;
        SliderUpDate();
        if (currentHP <= 0)
        {
            PlayerDie();
            StartCoroutine(DieProcess());
        }
    }

    void PlayerDie()
    {
        gameOverImage.gameObject.SetActive(true);
        StopAllCoroutines();
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
