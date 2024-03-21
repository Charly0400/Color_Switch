using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; 
    private GameObject lastObstacle;
    private bool isColliding = false;
    private bool firstObstacleTouched = false; // Variable para controlar si el primer obstáculo ha sido tocado

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ColorChanger") && firstObstacleTouched && !isColliding)
        {
            isColliding = true; 
            Transform spawnTransform = lastObstacle != null ? lastObstacle.transform.Find("Spawn") : transform;
            Spawn(spawnTransform);
            Destroy(other.gameObject); 
            isColliding = false; 
            //GetComponent<Collider2D>().isTrigger = false;
        }
    }

    public void Spawn(Transform spawnTransform)
    {
        int randomIndex = Random.Range(0, obstaclePrefabs.Length); 
        GameObject newObstacle = Instantiate(obstaclePrefabs[randomIndex], spawnTransform.position, Quaternion.identity);
        lastObstacle = newObstacle; 
    }
    public void FirstObstacleTouched()
    {
        // Método para activar la bandera indicando que el primer obstáculo ha sido tocado
        firstObstacleTouched = true;
    }
}
