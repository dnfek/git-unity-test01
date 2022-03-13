using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movespeed = 7f;
    CharacterController cc;
    // 중력 변수
    float gravity = -20f;
    // 수직 속력 변수
    float yvelocity = 0;
    // 점프력 변수
    public float jumppower = 10f;
    // 점프 상태 변수
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

        // 이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        // 메인 카메라를 기준으로 방향 변경
        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * movespeed * Time.deltaTime;
        
        // 점프 중이고, 바닥에 착지 했다면
        if(isjumping >= 1f && cc.collisionFlags == CollisionFlags.Below)
        {
            isjumping = 0f;
            yvelocity = 0;
        }

        //print(CollisionFlags.Below);
        //print(cc.collisionFlags);

        // 점프 구현
        if (Input.GetButtonDown("Jump") && isjumping <= 1f)
        {
            yvelocity = jumppower;
            isjumping += 1f; 
        }

        // 캐릭터의 수직 속도에 중력 값을 적용
        yvelocity += gravity * Time.deltaTime;
        dir.y = yvelocity;

        // 이동 함수
        cc.Move(dir * movespeed * Time.deltaTime);
    }
}
