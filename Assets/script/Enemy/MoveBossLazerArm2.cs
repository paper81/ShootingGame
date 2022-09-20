using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveBossLazerArm2 : MonoBehaviour
{
    public GameObject toPositionObj;
    public float speed;

    public void Move()
    {
        transform.DOMove(toPositionObj.transform.position, speed);
    }
}
