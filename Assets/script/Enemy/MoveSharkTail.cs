using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSharkTail : MonoBehaviour
{
    public float rotateSpeed = 1, MaxRotate, MinRotate;
    Vector3 rotate;
    bool IsUp = true;
    public float waitTime;
    Coroutine MoveCoroutine;

    void Start()
    {
        rotate = transform.localEulerAngles;
        //rotate.z = -(1 / (MaxRotate + MinRotate)) * rotateSpeed;
        MoveCoroutine = StartCoroutine(nameof(Move));
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(waitTime);
        while (true)
        {
            yield return null;
            //transform.Rotate(rotateSpeed * Time.deltaTime * rotate);
            transform.eulerAngles += rotateSpeed * Time.deltaTime * Vector3.forward;
            if ((transform.eulerAngles.z > MaxRotate && IsUp == true) || (transform.eulerAngles.z < -MinRotate && IsUp == false))
            { 
                rotateSpeed *= -1;
                IsUp = !IsUp;
            }
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
