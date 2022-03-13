using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ���⸦ �߻��� ��ġ ����
    public GameObject fireposition;

    // ���� ������Ʈ
    public GameObject bombfactory;
    
    // ��ô �Ŀ�
    public float throwpower = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 ��ư�� ���� ���⸦ �߻�
        if(Input.GetMouseButtonDown(1))
        {
            GameObject bomb = Instantiate(bombfactory);
            bomb.transform.position = fireposition.transform.position;
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            // ī�޶��� ���� �������� ���⿡ ������ ���� ����
            rb.AddForce(Camera.main.transform.forward * throwpower, ForceMode.Impulse);
        }
    }
}
