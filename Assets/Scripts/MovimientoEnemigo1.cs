using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo1 : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float distancia;
    private Rigidbody2D rb2d;
    private Vector2 posicionInicial;
    private bool moverDerecha = true;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        if (moverDerecha)
        {
            rb2d.velocity = new Vector2(velocidad, rb2d.velocity.y);
            if (transform.position.x >= posicionInicial.x + distancia)
            {
                moverDerecha = false;
            }
        }
        else
        {
            rb2d.velocity = new Vector2(-velocidad, rb2d.velocity.y);
            if(transform.position.x<= posicionInicial.x - distancia)
            {
                moverDerecha = true;
            }
        }


    }
}
