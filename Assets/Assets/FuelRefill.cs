using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelRefill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Car")
        {
            CarMovement.carinstance.fuel = 1.0f;
            Destroy(gameObject);
        }
        
    }
}
