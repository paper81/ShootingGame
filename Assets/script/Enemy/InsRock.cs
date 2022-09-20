using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsRock : MonoBehaviour
{
    public GameObject rock, flaw;
    public int destroyNum;
    const int insNum = 19;
    const float radius = 3;
    GameObject[] obj;
    void Start()
    {
        obj = new GameObject[insNum];
        for (int i = 0; i < insNum; i++)
        {
            obj[i] = Instantiate(rock, InsPos(i), Quaternion.identity, transform);                
        }
        Instantiate(flaw, obj[0].transform.position, new Quaternion(0,0,transform.rotation.z +90, 0), transform);
        for(int i = 0; i < destroyNum; i++)
            Destroy(obj[i]);
    }

    Vector3 InsPos(int num)
    {
        var angle = Mathf.PI * insNum / 180;
        var insPos = new Vector2(radius * Mathf.Cos(angle * num), radius * Mathf.Sin(angle * num));
        insPos += (Vector2)transform.position;
        return insPos;
    }
}
