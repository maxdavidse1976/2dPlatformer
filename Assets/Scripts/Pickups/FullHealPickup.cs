using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth.currentHealth < playerHealth.maximumHealth)
            {
                playerHealth.currentHealth = playerHealth.maximumHealth;
                Destroy(this.gameObject);
            }
        }
    }
}
