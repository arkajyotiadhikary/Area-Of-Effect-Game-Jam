using UnityEngine;
using UnityEngine.UI;

public class DriverDetails : MonoBehaviour
{
    enum driverState
    { 
        waiting,
        driving
    };
    driverState currentState = new driverState();

    StorePassangerData passangerData;


    public float totalTime;
    float time;
    public int driverSpeed;

    public InputField passengerName;
    public InputField PassengerID;
    public InputField PassengerLocation;

    void Start()
    {
        passangerData = GameObject.FindGameObjectWithTag("Notepad").GetComponent<StorePassangerData>();
        currentState = driverState.waiting;    
    }

    void Update()
    {
        if(time >= totalTime)
        {
            currentState = driverState.waiting;
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
                currentState = driverState.driving;
                totalTime = passangerData.time + driverSpeed;
                time = 0;
            }
        }
    }
}