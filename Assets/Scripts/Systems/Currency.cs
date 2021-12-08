using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public static int Coins;
    [SerializeField]
    private Text Display;

    public void Add_Coins(int Amount)
    {
        Coins += Amount;
        Display.text = Coins.ToString();
    }

    public void Remove_Coins(int Amount)
    {
        Coins -= Amount;
        Display.text = Coins.ToString();
    }
}
