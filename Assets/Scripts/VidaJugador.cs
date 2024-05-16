using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidaMaxima;
    [SerializeField] private float vidaActual;

    private void RecibirDa�o(float da�o)
    {
        vidaActual -= da�o;
        if(vidaActual < 0)
        {
            Debug.Log("JugadorMuerto");
            // logica de "Muerte" aca
            // puedes desactivar el Game Object del jugador o reniciar su nivel 
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