using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Ʈ������ ������Ʈ ���� ����
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ī�޶��� ��ġ�� target�� ��ġ�� ��ġ
        transform.position = target.position;
    }
}
