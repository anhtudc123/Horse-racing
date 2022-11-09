using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class FinishLine : MonoBehaviour
{
    public TMP_Text leaderBoard;
    public GameObject board;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        leaderBoard.text += other.gameObject.name + " - " + TimeSpan.FromSeconds(time).ToString("mm\\:ss\\.ff") + "\n";
        board.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            time = Time.realtimeSinceStartup;
        }
    }
}
