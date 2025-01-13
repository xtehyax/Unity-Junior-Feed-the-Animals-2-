using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn) // Only spawn a dog if the player can spawn one
        {
            StartCoroutine(SpawnDogWithDelay()); // Use a coroutine to delay the spawning of the dog
        }
    }

    private IEnumerator SpawnDogWithDelay() // Coroutine to delay the spawning of the dog
    {
        canSpawn = false; // Prevent the player from spawning another dog until the delay is over
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); // Spawn the dog
        yield return new WaitForSeconds(1); // Wait 3 seconds before allowing another dog to be sent
        canSpawn = true;
    }
}