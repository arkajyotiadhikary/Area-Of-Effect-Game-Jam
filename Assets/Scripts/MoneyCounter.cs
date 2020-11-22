using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    public Text moneyPlat;

    public int money;

    void Update()
    {
        moneyPlat.text = money.ToString();
    }
}
