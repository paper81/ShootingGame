using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    [SerializeField]
    AudioClip SE;
    [SerializeField]
    AudioSource audioSource;
    void Start()
    {
        audioSource.PlayOneShot(SE);
    }

    public void EndAnim()
    {
        Destroy(gameObject);
    }
}
