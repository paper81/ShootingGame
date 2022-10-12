using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCrab : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    float repeatTime;
    [SerializeField]
    AudioClip shotSE;

    [SerializeField]
    AudioSource audioSource;

    void Start()
    {
        InvokeRepeating(nameof(Shot), 0, repeatTime);
    }

    void Shot()
    {
        audioSource.PlayOneShot(shotSE);
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
