using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo2 : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float distancia;
    private Rigidbody2D rb2d;
    private Vector2 posicionInicial;
    private bool moverArriba = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }

    void Update()
    {
        Mover();
    }

    void Mover()
    {
        if (moverArriba)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, velocidad);
            if(transform.position.y >= posicionInicial.y + distancia)
            {
                moverArriba = false;
            }
        }
        else
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -velocidad);
            if(transform.position.y <= posicionInicial.y - distancia)
            {
                moverArriba = true;
            }
        }
    }
}
