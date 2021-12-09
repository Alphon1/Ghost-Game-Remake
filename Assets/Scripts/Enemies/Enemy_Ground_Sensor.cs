using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ground_Sensor : MonoBehaviour
{
    public bool Grounded = true;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Terrain" && Grounded == true)
        {
            Grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Terrain" && Grounded == false)
        {
            Grounded = true;
        }
    }
}
