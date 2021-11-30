using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Detection : MonoBehaviour
{
    private Player_Input Player_Input;

    private void Start()
    {
        Player_Input = gameObject.GetComponentInParent<Player_Input>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Player_Input.Is_Grounded == false)
        {
            Player_Input.Is_Grounded = true;
        }
    }
}
