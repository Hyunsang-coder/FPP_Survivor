using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHP = 100f;
    

    public void TakeDamage(float weaponDamage)
    {
        // 동일한 object + object의 children 내에 있는 스크립트 안의 함수만 가능! + getcomponent보다 훨씬 느림.
        BroadcastMessage("OnDamageTaken"); 
        enemyHP -= weaponDamage;
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log(transform.name + " has been destroyed.");
        }
    }
}
