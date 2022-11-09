using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isMoving=true;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        start();
        if (isMoving == true)
        {
            transform.position += Vector3.forward *  0.65f;
        }
    }
}
