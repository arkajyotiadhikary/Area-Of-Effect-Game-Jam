﻿using UnityEngine;
using UnityEngine.UI;
public class PassengerDetails : MonoBehaviour
{
    Reputation repu;

    StorePassangerData passangerData;

    // UI s
    public Image profilePic;
    public Text namePlate;
    public Slider emergencySlider;
    public Text moneyPlate;
    public Text TimeTakenPlate;

    // public
    public string[] names;
    public Sprite[] profilePics;
    public string[] locations;


    public float waitingTime;


    // private
    string passangerName;
    int emergency;
    int money;
    int time;
    int passengerID;
    string passengerLocation;


    private void Start()
    {
        repu = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Reputation>();

        passangerData = GameObject.FindGameObjectWithTag("Notepad").GetComponent<StorePassangerData>();

        waitingTime = Random.Range(10, 20);

        // randomize things
        passengerID = Random.Range(100, 10000);
        passengerLocation = locations[Random.Range(0, locations.Length)];
        time = Random.Range(5, 20);
        passangerName = names[Random.Range(0, names.Length)];
        emergency = Random.Range(0, 11);
        money = Random.Range(10, 101);
        profilePic.sprite = profilePics[Random.Range(0, profilePics.Length)];
        
        namePlate.text = passangerName;
        emergencySlider.value = emergency;
        moneyPlate.text = money.ToString();
        TimeTakenPlate.text = time.ToString();
    }
    private void Update()
    {
        if (waitingTime >= 0)
        {
            waitingTime -= Time.deltaTime;
        }
        else
        {
            if(emergency>7)
            {
                repu.reputation -= (emergency-7);
            }
            Destroy(gameObject);
        }
    }
    
    public void store()
    {
        passangerData.Store(passangerName, passengerID, passengerLocation, time,money,emergency);
        passangerData.dataStored = true;
    }
}
