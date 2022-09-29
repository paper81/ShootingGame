using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : GameScroll
{
    public Camera MainCamera;
    public float moveSpeed;
    public static bool IsMove;
    public Rigidbody2D rb2;
    Vector2 vel = Vector2.zero;

    protected override void Start()
    {
        base.Start();
        pos = transform.position;
    }

    void Update()
    {
        vel.x += Input.GetAxisRaw("Horizontal") * moveSpeed;
        vel.y += Input.GetAxisRaw("Vertical") * moveSpeed;
        vel.x = transform.position.x > MainCamera.transform.position.x +8.25f ? -moveSpeed : vel.x;
        vel.x = transform.position.x < MainCamera.transform.position.x -8.25f ?  moveSpeed : vel.x;
        vel.y = transform.position.y > MainCamera.transform.position.y +4.65f ? -moveSpeed : vel.y;
        vel.y = transform.position.y < MainCamera.transform.position.y -4.75f ?  moveSpeed : vel.y;
        pos += Scroll();
        rb2.velocity = vel;
        IsMove = rb2.velocity != Vector2.zero;
        vel = Vector2.zero;
    }
}
