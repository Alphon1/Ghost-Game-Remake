using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_Coin : MonoBehaviour
{
    private GameObject Game_Manager;

    private void Start()
    {
        Game_Manager = GameObject.FindWithTag("Manager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Game_Manager.GetComponent<Currency>().Add_Coins(1);
            gameObject.SetActive(false);
        }
    }
}
