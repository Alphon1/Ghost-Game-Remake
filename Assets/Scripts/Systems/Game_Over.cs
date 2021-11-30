using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    [SerializeField]
    private GameObject End_Screen;
    public void End_Game()
    {
        End_Screen.SetActive(true);
    }
}
