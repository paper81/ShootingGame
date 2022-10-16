using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    Camera MainCamera;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Rigidbody2D rb2;

    bool isMove;
    Vector2 vel = Vector2.zero;

    void Update()
    {
        vel.x += Input.GetAxisRaw("Horizontal") * moveSpeed;
        vel.y += Input.GetAxisRaw("Vertical") * moveSpeed;
        vel.x = transform.position.x > MainCamera.transform.position.x +8.25f ? -moveSpeed : vel.x;
        vel.x = transform.position.x < MainCamera.transform.position.x -8.25f ?  moveSpeed : vel.x;
        vel.y = transform.position.y > MainCamera.transform.position.y +4.65f ? -moveSpeed : vel.y;
        vel.y = transform.position.y < MainCamera.transform.position.y -4.75f ?  moveSpeed : vel.y;
        rb2.velocity = vel;
        isMove = rb2.velocity != Vector2.zero;
        vel = Vector2.zero;
    }

    public bool IsMove()
    {
        return isMove;
    }
}
