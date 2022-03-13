using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    // ȿ���� ���ŵ� �ð� ����
    public float destroytime = 1.5f;
    // ��� �ð� ���� ����
    float currenttime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currenttime > destroytime)
        {
            Destroy(gameObject);
        }
        currenttime += Time.deltaTime;
    }
}
