using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    // ȸ�� �ӵ� ���� 
    public float rotspeed = 200f;

    float mx = 0;
    float my = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 �Է��� ����
        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = Input.GetAxis("Mouse Y");

        // ȸ�� �� ������ ���콺 �Է� ���� ����
        mx += mouse_x * rotspeed * Time.deltaTime;
        my += mouse_y * rotspeed * Time.deltaTime;

        // ���콺 ���� �̵� ȸ�� ���� ���� ����
        my = Mathf.Clamp(my, -90f, 90f);

        transform.eulerAngles = new Vector3(-my, mx, 0);

        //// ȸ�� ���� ����
        //Vector3 dir = new Vector3(-mouse_y, mouse_x, 0);

        //// ��ü�� ȸ�� 
        //transform.eulerAngles += dir * rotspeed * Time.deltaTime;

        //// y���� ���� ���� 
        //Vector3 rot = transform.eulerAngles;
        //rot.x = Mathf.Clamp(rot.x, -90f, 90f);
        //transform.eulerAngles = rot;
    }
}
