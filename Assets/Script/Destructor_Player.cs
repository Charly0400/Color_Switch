using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor_Player : MonoBehaviour
{
    public GameObject gameOverPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
