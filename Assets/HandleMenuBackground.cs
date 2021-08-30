using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// creates a repeating background for the main menu of the game
// image slowly moves in the main menu
public class HandleMenuBackground : MonoBehaviour
{
    float scrollSpeed = -1f;
    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movementPosition = Mathf.Repeat(Time.time * scrollSpeed, 20);
        transform.position = startPosition + Vector2.right * movementPosition;
    }
}
