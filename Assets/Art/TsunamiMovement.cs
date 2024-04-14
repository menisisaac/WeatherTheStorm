using UnityEngine;
using System.Collections;

public class TsunamiMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceMagnitude = 12f; // Adjust this value to apply a "huge" force

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) {
            Debug.LogError("Rigidbody2D component is missing from the GameObject.");
            return;
        }

        // Apply a large force to the right (or any other direction)
        rb.AddForce(transform.right * forceMagnitude, ForceMode2D.Impulse);
    }
}