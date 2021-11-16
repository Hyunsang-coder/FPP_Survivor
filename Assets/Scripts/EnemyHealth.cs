using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHP = 100f;
    bool isDead = false;

    public bool IsDead() { return isDead; }

    public void TakeDamage(float weaponDamage)
    {
        // ������ object + object�� children ���� �ִ� ��ũ��Ʈ ���� �Լ��� ����! + getcomponent���� �ξ� ����.
        BroadcastMessage("OnDamageTaken"); 
        enemyHP -= weaponDamage;
        if (enemyHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;

        isDead = true;
        GetComponent<Animator>().SetTrigger("Die");
        Destroy(gameObject, 3f);
    }
}
