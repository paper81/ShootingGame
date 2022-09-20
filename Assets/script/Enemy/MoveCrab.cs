using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrab : MonoBehaviour
{
    Vector3 startPos , pos;
    public float speed;
    public float turnDirection;
    bool turn = false;

    void Start()
    {
        startPos = pos = transform.position;
    }

    private void Update()
    {
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if((transform.position.x < startPos.x - turnDirection && turn == true)|| 
            (transform.position.x > startPos.x + turnDirection && turn == false))
        {
            turn = !turn;
            speed *= -1;
        }
    }
}
