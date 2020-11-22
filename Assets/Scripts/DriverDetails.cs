using UnityEngine;
using UnityEngine.UI;

public class DriverDetails : MonoBehaviour
{
    public GameObject busy;
    public GameObject[] disable;

    MoneyCounter money;

    public enum driverState
    { 
        waiting,
        driving
    };
    
    public driverState currentState = new driverState();

    StorePassangerData passangerData;


    public float totalTime;
    float time;
    public int driverSpeed;

    public InputField passengerName;
    public InputField PassengerID;
    public InputField PassengerLocation;

    void Start()
    {
        money = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MoneyCounter>();
        passangerData = GameObject.FindGameObjectWithTag("Notepad").GetComponent<StorePassangerData>();
        currentState = driverState.waiting;    
    }

    void Update()
    {
        if(currentState == driverState.driving)
        {
            busy.SetActive(true);
            foreach (GameObject obj in disable)
            {
                obj.SetActive(false);
            }
        }

        if(currentState == driverState.waiting)
        {
            busy.SetActive(false);
            foreach (GameObject obj in disable)
            {
                obj.SetActive(true);
            }
        }

        // Time Managment
        if (time >= totalTime)
        {
            currentState = driverState.waiting;
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }
    public void order()
    {
        if(currentState == driverState.waiting)
        {
            if(passengerName.text == passangerData.passangerName && PassengerID.text == passangerData.id.ToString() && PassengerLocation.text == passangerData.location)
            {
                money.money += passangerData.money;
                passengerName.text = "";
                PassengerID.text = "";
                PassengerLocation.text = "";
                
                passangerData.dataStored = false;
                currentState = driverState.driving;
                totalTime = passangerData.time + driverSpeed;
                time = 0;
            }
        }
    }
}