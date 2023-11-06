using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapMover : MonoBehaviour
{

    public float speed; // Vitesse de déplacement de la Tilemap sur l'axe X
    float xPosition = 12f;

    private void Update()
    {
        xPosition = transform.position.x;

        float moveAmount = speed * Time.deltaTime;
        transform.Translate(Vector3.left * moveAmount);


        if (xPosition <= -23f)
        {
            xPosition = 12f;
            transform.Translate(35f, 0, 0);
            //PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
