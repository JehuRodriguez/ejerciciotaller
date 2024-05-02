using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float velocidad; 
    private Rigidbody2D rb2d;  

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        Mover();  
    }

    void Mover()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); //teclas A/D
        float vertical = Input.GetAxisRaw("Vertical"); //teclas W/S

        rb2d.velocity = new Vector2(horizontal, vertical).normalized * velocidad;
    }
}
