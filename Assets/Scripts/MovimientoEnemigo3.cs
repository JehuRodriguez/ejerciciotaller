using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo3 : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float distancia;
    private Rigidbody2D rb2d;
    private Vector2 posicionInicial;
    private bool moverDerechaArriba = true;


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
        if (moverDerechaArriba)
        {
            rb2d.velocity = new Vector2(velocidad, velocidad);
            if (transform.position.x >= posicionInicial.x + distancia || transform.position.y >= posicionInicial.y + distancia)
            {
                moverDerechaArriba = false;
            }
        }
        else
        {
            rb2d.velocity = new Vector2(-velocidad, -velocidad);
            if(transform.position.x<= posicionInicial.x - distancia || transform.position.y <= posicionInicial.y - distancia)
            {
                moverDerechaArriba = true;

            }
        }
    }
}
