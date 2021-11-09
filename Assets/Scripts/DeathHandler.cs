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
        Time.timeScale = 0; // 0이면 시간 멈춤 1이면 시간 진행
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
