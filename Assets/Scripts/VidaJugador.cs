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
        }
    }

   












    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
