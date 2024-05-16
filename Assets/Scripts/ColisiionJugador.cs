using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisiionJugador : MonoBehaviour
{
    private VidaJugador vidaJugador;
    private void Start()
    {
        vidaJugador = GetComponent<VidaJugador>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemigo1")) 
        {
            VidaJugador vidajugador = GetComponent<VidaJugador>();
            if(vidajugador != null)
            {
                vidajugador.RecibirDaño(50);
            }
        }
    }

}
