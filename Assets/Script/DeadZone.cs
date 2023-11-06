using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    public string sceneName; // Le nom de la sc�ne � red�marrer

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        Scene[] scenes = SceneManager.GetAllScenes();

        foreach (Scene scene in scenes)
        {
            // Charge chaque sc�ne active
            SceneManager.LoadScene(scene.name);
        }
    }
}
