using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    // 효과가 제거될 시간 변수
    public float destroytime = 1.5f;
    // 경과 시간 측정 변수
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
