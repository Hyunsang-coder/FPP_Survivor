using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHP = 100;

    
    public void TakeDamage(float damage)
    {
        playerHP -= damage;

        if (playerHP <= 0)
        {
            Debug.Log("Player is dead.");
            GetComponent<DeathHandler>().HandleDeath();
            FindObjectOfType<EnemyAI>().isProvoked = false;
        }
    }


}
