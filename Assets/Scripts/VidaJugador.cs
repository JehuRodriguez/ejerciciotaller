using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidaMaxima;
    [SerializeField] private float vidaActual;

    public void RecibirDaño(float daño)
    {
        vidaActual -= daño;
        if(vidaActual <= 0)
        {
            Debug.Log("JugadorMuerto");
            // logica de "Muerte" aca
            // puedes desactivar el Game Object del jugador o reniciar su nivel 
            // gameObject.SetActive(false)
        }
        else 
        {
            Debug.Log("El jugador a perdido 50 puntos ");
            Debug.Log("El jugador a perdido 40 puntos ");
        }

    }

    void Start()
    {
        vidaActual = vidaMaxima;
    }

    
    void Update()
    {
        
    }
}
