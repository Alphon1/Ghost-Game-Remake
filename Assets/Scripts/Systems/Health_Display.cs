using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Display : MonoBehaviour
{
    [SerializeField]
    private GameObject Heart2;
    [SerializeField]
    private GameObject Heart3;

    public void Update_Display(int Health)
    {
        if (Health == 3)
        {
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
        else if (Health == 2)
        {
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        }
        else if (Health == 1)
        {
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
    }
}
