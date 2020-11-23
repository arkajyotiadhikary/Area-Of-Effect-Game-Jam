using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   public GameObject HowToPlay;
   public void close()
    {
        Destroy(HowToPlay);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
