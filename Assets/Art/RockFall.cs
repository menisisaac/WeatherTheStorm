using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class RockFall : MonoBehaviour
{
    public GameObject spritePrefab;  // Assign this in the inspector with your prefab
    public float speed = 5f;         // Speed at which the sprite moves

    public void Start() {
        SpawnAndMoveSprite();
    }
    // Function to be called by button click
    public void SpawnAndMoveSprite()
    {
        // Calculate the starting position off-screen to the left
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 startPosition = new Vector3(0, height / 2 + 1f, 0);

        // Instantiate the sprite at the starting position
        GameObject sprite = Instantiate(spritePrefab, startPosition, Quaternion.identity);

        // Start moving the sprite
        StartCoroutine(MoveSprite(sprite));
    }

    private System.Collections.IEnumerator MoveSprite(GameObject sprite)
    {
        // Calculate the end position off-screen to the right
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 endPosition = new Vector3(0, height / 2 - 1f, 0);

        // Move the sprite until it reaches the end position
        while (sprite.transform.position.y > endPosition.y)
        {
            sprite.transform.position -= Vector3.up * speed * Time.deltaTime;
            yield return null;
        }

        // Optionally destroy the sprite once it moves off screen
        Destroy(sprite);
    }
}