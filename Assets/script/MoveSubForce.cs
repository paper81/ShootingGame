using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSubForce : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject parent;
    [SerializeField]
    int spam;

    MovePlayer movePlayer;
    List<Vector2> vector2s = new List<Vector2>();

    private void Start()
    {
        movePlayer = player.GetComponent<MovePlayer>();
    }

    void FixedUpdate()
    {
        if (movePlayer.IsMove() == false || player == null)
        {
            return;
        }

        vector2s.Add(parent.transform.position);

        if(vector2s.Count - spam >= 0)
        {
            transform.position = vector2s[vector2s.Count - spam];
        }
    }
}
