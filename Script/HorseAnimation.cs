using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseAnimation : MonoBehaviour
{
    Animator animHorse;
    // Start is called before the first frame update
    void Start()
    {
        animHorse = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animHorse.SetTrigger("Running");
        }
    }
}
