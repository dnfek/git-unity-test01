using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    public GameObject bombeffect;

    public float time = 0f;

    // 충돌체 처리 함수 구현
    private void OnCollisionEnter(Collision collision)
    {
        // 이펙트 프리팹 생성
        GameObject eff = Instantiate(bombeffect);

        // 이펙트 프리팹 위치 설정
        eff.transform.position = transform.position;

        // 자기 오브젝트를 제거
        Destroy(gameObject);
    }

    //// 충돌체 처리 함수 구현
    //private void OnCollisionStay(Collision collision)
    //{
    //    print(time);
    //    if (time >= 3f)
    //    {
    //        // 이펙트 프리팹 생성
    //        GameObject eff = Instantiate(bombeffect);

    //        // 이펙트 프리팹 위치 설정
    //        eff.transform.position = transform.position;

    //        // 자기 오브젝트를 제거
    //        Destroy(gameObject);
    //    }
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
    }
}
