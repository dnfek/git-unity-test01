using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Mouse Y");
        float b = Input.GetAxis("Vertical");
        float c = Input.GetAxis("Horizontal");
        a = a * speed * Time.deltaTime * 10;
        b = b * speed * Time.deltaTime;
        c = c * speed * Time.deltaTime;
        transform.Translate(Vector3.up * a);
        transform.Translate(Vector3.forward * b);
        transform.Translate(Vector3.left * c);
        //transform.Translate(Vector3.up / 100);
    }
}
