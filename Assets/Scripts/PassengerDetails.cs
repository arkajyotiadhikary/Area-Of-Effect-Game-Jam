using UnityEngine;
using UnityEngine.UI;
public class PassengerDetails : MonoBehaviour
{

    // UI s
    public Image profilePic;
    public Text namePlate;
    public Slider emergencySlider;
    public Text moneyPlate;
    public Text TimeTakenPlate;

    // public
    public string[] names;
    public Sprite[] profilePics;

    public float waitingTime;


    string passangerName;
    
    int emergency;
    int money;
    int time;
    
    private void Start()
    {
        waitingTime = Random.Range(10, 20);

        time = Random.Range(1, 11);
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
            Destroy(gameObject);
        }
    }
}
