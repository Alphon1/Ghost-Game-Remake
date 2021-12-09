using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Over : MonoBehaviour
{
    [SerializeField]
    private GameObject End_Screen;
    private bool Screen_Shown;
    [SerializeField]
    private Sprite Win_Sprite;

    public void End_Game(bool Win)
    {
        if (Win == true)
        {
            End_Screen.GetComponent<Image>().sprite = Win_Sprite;
        }
        End_Screen.SetActive(true);
        Screen_Shown = true;
    }

    private void Update()
    {
        if (Screen_Shown)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}
