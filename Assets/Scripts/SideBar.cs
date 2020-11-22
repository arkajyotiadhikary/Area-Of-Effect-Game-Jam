using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SideBar : MonoBehaviour
{
    public GameObject passenfer;

    public GameObject[] DriverSection;

    public GameObject[] PassengerSection;

    int btn = 1;

    public void driver()
    {
        btn = 1;
    }

    public void passenger()
    {
        btn = 2;
    }

    private void Update()
    {
        PassengerSection = GameObject.FindGameObjectsWithTag("Passenger");

        switch (btn)
        {
            case 1:
                {
                    foreach (GameObject Dobj in DriverSection)
                    {
                        if (Dobj.GetComponent<Text>() != null)
                        {
                            Dobj.GetComponent<Text>().enabled = true;
                        }
                        if (Dobj.GetComponent<InputField>() != null)
                        {
                            Dobj.GetComponent<InputField>().enabled = true;
                        }
                        if (Dobj.GetComponent<Image>() != null)
                        {
                            Dobj.GetComponent<Image>().enabled = true;
                        }
                    }

                    foreach (GameObject Pobj in PassengerSection)
                    {
                        if (Pobj.GetComponent<Text>() != null)
                        {
                            Pobj.GetComponent<Text>().enabled = false;
                        }
                        if (Pobj.GetComponent<InputField>() != null)
                        {
                            Pobj.GetComponent<InputField>().enabled = false;
                        }
                        if (Pobj.GetComponent<Image>() != null)
                        {
                            Pobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    break;
                }
            case 2:
                {
                    foreach (GameObject _Dobj in DriverSection)
                    {
                        if (_Dobj.GetComponent<Text>() != null)
                        {
                            _Dobj.GetComponent<Text>().enabled = false;
                        }
                        if (_Dobj.GetComponent<InputField>() != null)
                        {
                            _Dobj.GetComponent<InputField>().enabled = false;
                        }
                        if (_Dobj.GetComponent<Image>() != null)
                        {
                            _Dobj.GetComponent<Image>().enabled = false;
                        }
                    }

                    foreach (GameObject _Pobj in PassengerSection)
                    {
                        if (_Pobj.GetComponent<Text>() != null)
                        {
                            _Pobj.GetComponent<Text>().enabled = true;
                        }
                        if (_Pobj.GetComponent<InputField>() != null)
                        {
                            _Pobj.GetComponent<InputField>().enabled = true;
                        }
                        if (_Pobj.GetComponent<Image>() != null)
                        {
                            _Pobj.GetComponent<Image>().enabled = true;
                        }
                    }
                    break;
                }
        }
    }
}
