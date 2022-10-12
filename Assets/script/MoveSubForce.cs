using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSubForce : MonoBehaviour
{
    public GameObject player;
    public int spam;
    List<Vector2> vector2s = new List<Vector2>();

    void FixedUpdate()
    {
        if (!MovePlayer.IsMove || player == null)
        {
            return;
        }

        vector2s.Add(player.transform.position);

        if(vector2s.Count - spam >= 0)
        {
            transform.position = vector2s[vector2s.Count - spam];
        }
    }
}
