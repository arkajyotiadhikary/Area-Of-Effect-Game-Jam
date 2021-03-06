﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SideBar : MonoBehaviour
{
    public GameObject passenfer;

    public GameObject[] DriverSection;

    public GameObject[] PassengerSection;

    public GameObject[] MoneySection;

    public GameObject[] ReputationSection;

    int btn = 1;

    public void driver()
    {
        btn = 1;
    }

    public void passenger()
    {
        btn = 2;
    }
    public void moneyBTN()
    {
        btn = 3;
    }

    public void repuBTN()
    {
        btn = 4;
    }

    private void Update()
    {
        PassengerSection = GameObject.FindGameObjectsWithTag("Passenger");
        DriverSection = GameObject.FindGameObjectsWithTag("Driver");
        MoneySection = GameObject.FindGameObjectsWithTag("Money");
        ReputationSection = GameObject.FindGameObjectsWithTag("Reputation");

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
                    
                    foreach (GameObject Robj in ReputationSection)
                    {
                        if (Robj.GetComponent<Text>() != null)
                        {
                            Robj.GetComponent<Text>().enabled = false;
                        }
                        if (Robj.GetComponent<InputField>() != null)
                        {
                            Robj.GetComponent<InputField>().enabled = false;
                        }
                        if (Robj.GetComponent<Image>() != null)
                        {
                            Robj.GetComponent<Image>().enabled = false;
                        }
                    }

                    foreach (GameObject Mobj in MoneySection)
                    {
                        if (Mobj.GetComponent<Text>() != null)
                        {
                            Mobj.GetComponent<Text>().enabled = false;
                        }
                        if (Mobj.GetComponent<InputField>() != null)
                        {
                            Mobj.GetComponent<InputField>().enabled = false;
                        }
                        if (Mobj.GetComponent<Image>() != null)
                        {
                            Mobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    break;
                }
            case 2:
                {
                    foreach (GameObject Robj in ReputationSection)
                    {
                        if (Robj.GetComponent<Text>() != null)
                        {
                            Robj.GetComponent<Text>().enabled = false;
                        }
                        if (Robj.GetComponent<InputField>() != null)
                        {
                            Robj.GetComponent<InputField>().enabled = false;
                        }
                        if (Robj.GetComponent<Image>() != null)
                        {
                            Robj.GetComponent<Image>().enabled = false;
                        }
                    }
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

                    foreach (GameObject Mobj in MoneySection)
                    {
                        if (Mobj.GetComponent<Text>() != null)
                        {
                            Mobj.GetComponent<Text>().enabled = false;
                        }
                        if (Mobj.GetComponent<InputField>() != null)
                        {
                            Mobj.GetComponent<InputField>().enabled = false;
                        }
                        if (Mobj.GetComponent<Image>() != null)
                        {
                            Mobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    break;
                }
            case 3:
                {
                    foreach (GameObject Robj in ReputationSection)
                    {
                        if (Robj.GetComponent<Text>() != null)
                        {
                            Robj.GetComponent<Text>().enabled = false;
                        }
                        if (Robj.GetComponent<InputField>() != null)
                        {
                            Robj.GetComponent<InputField>().enabled = false;
                        }
                        if (Robj.GetComponent<Image>() != null)
                        {
                            Robj.GetComponent<Image>().enabled = false;
                        }
                    }

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
                            _Pobj.GetComponent<Text>().enabled = false;
                        }
                        if (_Pobj.GetComponent<InputField>() != null)
                        {
                            _Pobj.GetComponent<InputField>().enabled = false;
                        }
                        if (_Pobj.GetComponent<Image>() != null)
                        {
                            _Pobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    foreach (GameObject Mobj in MoneySection)
                    {
                        if (Mobj.GetComponent<Text>() != null)
                        {
                            Mobj.GetComponent<Text>().enabled = true;
                        }
                        if (Mobj.GetComponent<InputField>() != null)
                        {
                            Mobj.GetComponent<InputField>().enabled = true;
                        }
                        if (Mobj.GetComponent<Image>() != null)
                        {
                            Mobj.GetComponent<Image>().enabled = true;
                        }
                    }
                    break;
                }

            case 4:
                {
                    foreach (GameObject Robj in ReputationSection)
                    {
                        if (Robj.GetComponent<Text>() != null)
                        {
                            Robj.GetComponent<Text>().enabled = true;
                        }
                        if (Robj.GetComponent<InputField>() != null)
                        {
                            Robj.GetComponent<InputField>().enabled = true;
                        }
                        if (Robj.GetComponent<Image>() != null)
                        {
                            Robj.GetComponent<Image>().enabled = true;
                        }
                    }

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
                            _Pobj.GetComponent<Text>().enabled = false;
                        }
                        if (_Pobj.GetComponent<InputField>() != null)
                        {
                            _Pobj.GetComponent<InputField>().enabled = false;
                        }
                        if (_Pobj.GetComponent<Image>() != null)
                        {
                            _Pobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    foreach (GameObject Mobj in MoneySection)
                    {
                        if (Mobj.GetComponent<Text>() != null)
                        {
                            Mobj.GetComponent<Text>().enabled = false;
                        }
                        if (Mobj.GetComponent<InputField>() != null)
                        {
                            Mobj.GetComponent<InputField>().enabled = false;
                        }
                        if (Mobj.GetComponent<Image>() != null)
                        {
                            Mobj.GetComponent<Image>().enabled = false;
                        }
                    }
                    break;
                }
        }
    }
}
