using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLif : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("DamageWall"))
        {
            Destroy(gameObject);
        }
    }
}
