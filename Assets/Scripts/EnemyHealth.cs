using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHP = 100f;
    

    public void TakeDamage(float weaponDamage)
    {
        enemyHP -= weaponDamage;

        if (enemyHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log(transform.name + " has been destroyed.");
        }
    }
}
