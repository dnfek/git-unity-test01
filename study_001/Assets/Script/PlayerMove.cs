using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movespeed = 7f;
    CharacterController cc;
    // �߷� ����
    float gravity = -20f;
    // ���� �ӷ� ����
    float yvelocity = 0;
    // ������ ����
    public float jumppower = 10f;
    // ���� ���� ����
    public float isjumping = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �̵� ���� ����
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        // ���� ī�޶� �������� ���� ����
        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * movespeed * Time.deltaTime;
        
        // ���� ���̰�, �ٴڿ� ���� �ߴٸ�
        if(isjumping >= 1f && cc.collisionFlags == CollisionFlags.Below)
        {
            isjumping = 0f;
            yvelocity = 0;
        }

        //print(CollisionFlags.Below);
        //print(cc.collisionFlags);

        // ���� ����
        if (Input.GetButtonDown("Jump") && isjumping <= 1f)
        {
            yvelocity = jumppower;
            isjumping += 1f; 
        }

        // ĳ������ ���� �ӵ��� �߷� ���� ����
        yvelocity += gravity * Time.deltaTime;
        dir.y = yvelocity;

        // �̵� �Լ�
        cc.Move(dir * movespeed * Time.deltaTime);
    }
}
