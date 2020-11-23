using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerSpawn : MonoBehaviour
{
    // Time Managment
    public float passengerSpawnDelay;
    float time;

    //
    public GameObject passengerList;
    public GameObject passengerDetail;


    void Start()
    {
        passengerSpawnDelay = Random.Range(2, 5);
    }
    // Update is called once per frame
    void Update()
    {
        if(time>=passengerSpawnDelay)
        {
            Spawn();
            passengerSpawnDelay = Random.Range(2, 10);
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }

    void Spawn()
    {
        Instantiate(passengerDetail, passengerList.transform);
    }
}
