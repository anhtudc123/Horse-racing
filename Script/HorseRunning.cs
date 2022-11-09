using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HorseRunning : MonoBehaviour
{
    float horseSpeed;
    bool isRunning=false;
    float trackTime;
    public GameObject horse1;
    public GameObject horse2;
    public GameObject horse3;
    public GameObject horse4;
    public GameObject horse5;
    public GameObject horse6;
    public GameObject horse7;
    public GameObject horse8;
    public Text First;
    public Text Second;
    public Text Third;
    public TMP_Text leaderBoard;
    public GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        //animHorse = GetComponent<Animator>();
    }
    public void StartRace()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //animHorse.SetTrigger("Running");
            isRunning = true;
            roadMesure();
        }
    }

    public void horseRunning(GameObject horse)
    {
        //Invoke("AdjustSpeed", 2.0f);

        if (isRunning == true)
        {
            trackTime = Time.realtimeSinceStartup;
            if (Time.deltaTime < 2)
            {
                horseSpeed = Random.Range(0.5f, 0.8f);

            }
            
            if (Time.deltaTime % 2 == 0&&Time.deltaTime>=2)
            {
                horseSpeed = Random.Range(0.5f, 0.8f);
            }
            horse.transform.position += Vector3.forward * horseSpeed;
        }
    }
    public void roadMesure()
    {
        float[] road = new float[9];
        road[0] = horse1.transform.position.z;
        road[1] = horse2.transform.position.z;
        road[2] = horse3.transform.position.z;
        road[3] = horse4.transform.position.z;
        road[4] = horse5.transform.position.z;
        road[5] = horse6.transform.position.z;
        road[6] = horse7.transform.position.z;
        road[7] = horse8.transform.position.z;
        float[]road01 = new float[9];
        for(int i=0; i<8; i++)
        {
            road01[i] = road[i];
        }
        for(int i = 0; i < 8; i++)
        {
            for(int j = i + 1; j < 8; j++)
            {
                if (road[i] < road[j])
                {
                    road[8] = road[i];
                    road[i] = road[j];
                    road[j] = road[8];
                }
            }
        }
        First.text = findByLocal(road[1], road01);
        Second.text= findByLocal(road[2], road01);
        Third.text= findByLocal(road[3], road01);
        string findByLocal(float local, float[] horse)
        {
            for (int i = 0; i < 8; i++)
            {
                if (local == horse[i])
                {
                    return "horse "+(i+1).ToString();
                }
            }
            return "#";
        }
    }
    //public void OnTriggerEnter(Collider other)
    //{
    //    leaderBoard.text += other.gameObject.name + " - " + TimeSpan.FromSeconds(trackTime).ToString("mm\\:ss\\.ff") + "\n";
    //    board.SetActive(true);
    //}

    // Update is called once per frame
    void Update()
    {
        StartRace();
        horseRunning(horse1);
        horseRunning(horse2);
        horseRunning(horse3);
        horseRunning(horse4);
        horseRunning(horse5);
        horseRunning(horse6);
        horseRunning(horse7);
        horseRunning(horse8);
        roadMesure();
    }

}
