using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical_AI : MonoBehaviour
{
    private bool Going_Down = true;

    // Update is called once per frame
    void Update()
    {
        if (Going_Down)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 20);
            if (transform.position.y < 30)
            {
                Going_Down = false;
            }
        }
        else
        {
            transform.Translate(Vector3.up * Time.deltaTime * 20);
            if (transform.position.y > 100)
            {
                Going_Down = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            Going_Down = !Going_Down;
        }
    }
}
