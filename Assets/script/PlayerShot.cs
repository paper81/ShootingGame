using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShot : MonoBehaviour
{
    public PlayerStatus status;
    public Slider slider_Charge;
    public GameObject chargeEffect;
    public GameObject[] bullet;
    public GameObject[] chargeBullet;
    public GameObject[] muzzle;

    GameObject chargeObj;
    float time;

    void Start()
    {
        slider_Charge.value = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("ShotButton"))
        {
            time = 0;
            chargeObj = Instantiate(chargeEffect, muzzle[0].transform.position, Quaternion.identity);
        }
        if (Input.GetButton("ShotButton"))
        {
            time += Time.deltaTime;
            slider_Charge.value = time / status.chargeTime;
            chargeObj.transform.position = muzzle[0].transform.position;
        }
        else
        {
            slider_Charge.value = 0;
            Destroy(chargeObj);
        }
        if (Input.GetButtonUp("ShotButton"))
        {
            Destroy(chargeObj);
            slider_Charge.value = 0;
            if(time < status.chargeTime)
                Shot(bullet[status.bulletLevel]);
            if (time > status.chargeTime)
                Shot(chargeBullet[status.bulletLevel]);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bullet"></param>
    void Shot(GameObject bullet)
    {
        for(int i = 0; i < status.muzzleLevel; i++)
        {
            Instantiate(bullet, muzzle[i].transform.position, Quaternion.identity);
        }
    }
}
