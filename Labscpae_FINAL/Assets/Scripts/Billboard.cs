using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    void Update()
    {
        // ���� ī�޶��� ���� ����� ���� ���� ������ ��ġ��Ų��.
        transform.forward = Camera.main.transform.forward;
    }
}