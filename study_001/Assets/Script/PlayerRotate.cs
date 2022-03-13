using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotspeed = 200f;
    float mx = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X");
        mx += mouse_x * rotspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }
}
