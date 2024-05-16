using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarVida : MonoBehaviour
{
    public float CantidadRecuperacion = 30f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            VidaJugador vidaJugador = other.GetComponent<VidaJugador>();

            if(vidaJugador != null)
            {
                vidaJugador.RecuperarVida(CantidadRecuperacion);
                Destroy(gameObject);
            }
        }
    }
}
