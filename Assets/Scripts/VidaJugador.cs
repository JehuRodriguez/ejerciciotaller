using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidaMaxima;
    [SerializeField] private float vidaActual;

    public void RecibirDa�o(float da�o)
    {
        vidaActual -= da�o;
        if(vidaActual <= 0)
        {
            Debug.Log("JugadorMuerto");
            // logica de "Muerte" aca
            // puedes desactivar el Game Object del jugador o reniciar su nivel 
            // gameObject.SetActive(false)
        }
        else 
        {
            Debug.Log("El jugador ha perdido" + da�o + "puntos de vida ");
        }

    }

    void Start()
    {
        vidaActual = vidaMaxima;
    }

    public void RecuperarVida(float cantidadRecuperacion)
    {
        vidaActual += cantidadRecuperacion;
        vidaActual = Mathf.Min(vidaActual, vidaMaxima);
        Debug.Log("El jugador a recuperado " + cantidadRecuperacion + " puntos de vida");
    }
  
    
}
