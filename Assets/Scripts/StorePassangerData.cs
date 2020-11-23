using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StorePassangerData : MonoBehaviour,IDragHandler
{
    // UI s
    public Text namePlate;
    public Text IdPlate;
    public Text locationPlate;
    public Text timePlate;

    // datas
    public string passangerName;
    public int id;
    public string location;
    public int time;
    public int money;
    public int emergency;

    public bool dataStored;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void Store(string _name,int _id,string _location,int _time,int _money,int _emergancy)
    {
        emergency = _emergancy;
        money = _money;
        passangerName = _name;
        id = _id;
        location = _location;
        time = _time;

        namePlate.text = passangerName;
        IdPlate.text = id.ToString();
        locationPlate.text = location;
        timePlate.text = time.ToString();
    }
}
