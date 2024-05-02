using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletprefab;
    private PlayerMovement playerMovement;

    
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();

    }

    
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bulletprefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulettMovement>().SetDirection(playerMovement.Direction.normalized);
        }
    }
}
