using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    private int Max_Health = 3;
    private int Current_Health = 3;
    private GameObject Game_Manager;
    [SerializeField]
    private GameObject Health_UI;
    private float Damage_Cooldown;
    private bool Iframes;
    [SerializeField]
    private GameObject Shield;

    private void Start()
    {
        Game_Manager = GameObject.FindWithTag("Manager");

    }

    private void FixedUpdate()
    {
        if (Iframes == true)
        {
            Damage_Cooldown -= 1;
            if (Damage_Cooldown < 1)
            {
                Shield.SetActive(false);
                Iframes = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && Iframes == false)
        {
            Current_Health -= 1;
            Iframes = true;
            Shield.SetActive(true);
            Damage_Cooldown = 180;
            if (Current_Health < 1)
            {
                Game_Manager.GetComponent<Game_Over>().End_Game(false);
                gameObject.SetActive(false);
            }
            Health_UI.GetComponent<Health_Display>().Update_Display(Current_Health);
        }
    }
}
