using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    public GameObject bombeffect;

    public float time = 0f;

    // �浹ü ó�� �Լ� ����
    private void OnCollisionEnter(Collision collision)
    {
        // ����Ʈ ������ ����
        GameObject eff = Instantiate(bombeffect);

        // ����Ʈ ������ ��ġ ����
        eff.transform.position = transform.position;

        // �ڱ� ������Ʈ�� ����
        Destroy(gameObject);
    }

    //// �浹ü ó�� �Լ� ����
    //private void OnCollisionStay(Collision collision)
    //{
    //    print(time);
    //    if (time >= 3f)
    //    {
    //        // ����Ʈ ������ ����
    //        GameObject eff = Instantiate(bombeffect);

    //        // ����Ʈ ������ ��ġ ����
    //        eff.transform.position = transform.position;

    //        // �ڱ� ������Ʈ�� ����
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
