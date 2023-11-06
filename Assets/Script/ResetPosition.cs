using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject[] Tuyau; // Tableau contenant les objets à déplacer
    Vector2 destinationPoint = new Vector2(12f, 0f); // Point de destination où les objets seront déplacés

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject objet in Tuyau)
            {
                objet.transform.position = destinationPoint;
            }

        }
    }
}
