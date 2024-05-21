using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public Transform[] paths;
    private int curIndex = 0;
    public int maxIndex;
    private Vector3 move = Vector3.zero;

    private void Start()
    {
        maxIndex = paths.Length;
    }

    public void FixedUpdate()
    {
        if (maxIndex - 1 < curIndex)
        {  
            //  ���� ����
            return;
        }

        //  0.00001�� ���� ������ ����
        if (paths[curIndex].position.magnitude - transform.position.magnitude<0.00001)
        {
            curIndex++;
        }

        move = paths[curIndex].position - paths[curIndex - 1].position;

        transform.position += moveSpeed * move * Time.deltaTime;
    }



}
