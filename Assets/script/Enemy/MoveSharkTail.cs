using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSharkTail : MonoBehaviour
{
    public float rotateSpeed = 1, MaxRotate, MinRotate;
    Vector3 rotate;
    public float waitTime;
    Coroutine MoveCoroutine;

    void Start()
    {
        rotate.z = rotateSpeed * 0.01f;
        //rotate.z = -(1 / (MaxRotate + MinRotate)) * rotateSpeed;
        MoveCoroutine = StartCoroutine(nameof(Move));
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(waitTime);
        while (true)
        {
            yield return null;
            transform.Rotate(rotate * Time.deltaTime);
            if (ChangeAngle() > MaxRotate || ChangeAngle() < -MinRotate)
                rotate *= -1;
        }
    }

    float ChangeAngle()
    {
        var rotate = transform.localEulerAngles.z;
        if (rotate > 180)
        {
            rotate -= 360;
        }

        return rotate;
    }

    public void Stop()
    {
        StopCoroutine(MoveCoroutine);
    }
}
