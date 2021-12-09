using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal_AI : MonoBehaviour
{
    private bool Going_Left = true;

    [SerializeField]
    private GameObject Ground_Sensor;

    private bool Collision_Over = true;

    void FixedUpdate()
    {
        if (Going_Left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 25);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * 25);
        }
        if (Ground_Sensor.GetComponent<Enemy_Ground_Sensor>().Grounded == false)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            Going_Left = !Going_Left;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Terrain" && Collision_Over == true)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            Going_Left = !Going_Left;
            Collision_Over = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            Collision_Over = true;
        }
    }
}
