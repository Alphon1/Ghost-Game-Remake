using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour
{
    private Rigidbody2D Body;
    private Vector2 Move_Input;
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float Jump_Force;
    public bool Is_Grounded = true;

    private GameObject Game_Manager;
    // Start is called before the first frame update
    void Start()
    {
        Body = gameObject.GetComponent<Rigidbody2D>();
        Game_Manager = GameObject.FindWithTag("Manager");
    }

    private void Update()
    {
        Move_Input = new Vector2(Input.GetAxis("Horizontal") * Speed, Body.velocity.y);
        Body.velocity = Move_Input;
        if ( Input.GetButton("Vertical") && Is_Grounded)
        {          
            Body.AddForce(new Vector2(0, Jump_Force));
            Is_Grounded = false;
        }
        if (gameObject.transform.position.y < 20)
        {
            Game_Manager.GetComponent<Game_Over>().End_Game();
            gameObject.SetActive(false);
        }
    }
}
