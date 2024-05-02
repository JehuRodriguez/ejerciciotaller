using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Vector2 direction; 

    public Vector2 Direction
    {
        get
        {
            return direction;
        }
    }



    // Start is called before the first frame update
    public void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        direction = Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if(horizontal !=0f || vertical != 0f)
        {
            direction = new Vector2(horizontal, vertical).normalized;
        }

        rb2d.velocity = new Vector2(horizontal, vertical).normalized * speed;
    }
}
