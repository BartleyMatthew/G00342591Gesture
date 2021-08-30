using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Infinite repeating background that follows the player
// easier for level design - no need for tile map backgrounds
// dynamic and can be easily changed
public class BackgroundRepeater : MonoBehaviour
{
    private float speed = 0.1f;
    private string sortLayer = string.Empty;
    public Material material;
    public MeshRenderer render;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().sortingOrder = 0;
    }

    void Update()
    {
        Vector2 backgroundOffset = new Vector2(Time.time * speed, 5);
        material.mainTextureOffset = backgroundOffset;
    }
}
