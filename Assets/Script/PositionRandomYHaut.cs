using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRandomHaut : MonoBehaviour
{
    float xPosition = 11f;
    float yPosition;
    void Update()
    {
        xPosition = transform.position.x;

        if (xPosition >= 11f && xPosition < 12f)
        {
            yPosition = Random.Range(0, 1.67f);
            //Debug.Log("La valeur de y est : " + yPosition);
            transform.position = new Vector2(11f, -yPosition);
        }
    }
}
