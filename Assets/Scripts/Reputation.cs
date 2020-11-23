using UnityEngine;
using UnityEngine.UI;

public class Reputation : MonoBehaviour
{
    public int reputation;
    public Slider reputationBar;
    void Start()
    {
        reputation = 100;
    }
    
    // Update is called once per frame
    void Update()
    {
        reputationBar.value = reputation;
        
        if(reputation<=0)
        {
            Application.Quit();
        }
    }
}
