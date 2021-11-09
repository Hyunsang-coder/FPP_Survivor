using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0; // 0�̸� �ð� ���� 1�̸� �ð� ����
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
