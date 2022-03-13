using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 무기를 발사할 위치 지정
    public GameObject fireposition;

    // 무기 오브젝트
    public GameObject bombfactory;
    
    // 투척 파워
    public float throwpower = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 버튼을 통해 무기를 발상
        if(Input.GetMouseButtonDown(1))
        {
            GameObject bomb = Instantiate(bombfactory);
            bomb.transform.position = fireposition.transform.position;
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            // 카메라의 정면 방향으로 무기에 물리적 힘을 가함
            rb.AddForce(Camera.main.transform.forward * throwpower, ForceMode.Impulse);
        }
    }
}
