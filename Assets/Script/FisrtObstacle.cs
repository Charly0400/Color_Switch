using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisrtObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Obtener la referencia al script SpawnObstacle y llamar al m?todo FirstObstacleTouched
            SpawnObstacle spawnObstacle = FindObjectOfType<SpawnObstacle>();
            if (spawnObstacle != null)
            {
                spawnObstacle.FirstObstacleTouched();
            }
        }
    }
}
