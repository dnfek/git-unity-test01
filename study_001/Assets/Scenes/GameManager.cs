using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
        a = a * speed * Time.deltaTime;
        b = b * speed * Time.deltaTime;
        transform.Translate(Vector3.left * a);
        transform.Translate(Vector3.up * b);
        //transform.Translate(Vector3.up / 100);
    }
}
