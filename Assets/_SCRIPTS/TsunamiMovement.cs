using UnityEngine;
using System.Collections;

public class TsunamiMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // GameManager levelController;
    public float forceMagnitude = 6f; // * levelController; // Adjust this value to apply a "huge" force

    void Awake() {
        // Cache the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) {
            Debug.LogError("Rigidbody2D component is missing from the GameObject.");
        }
    }
    public void ApplyTsunamiForce() {
        if (rb != null) {
            // Apply a large force to the right (or any other direction)
            rb.AddForce(transform.right * forceMagnitude, ForceMode2D.Impulse);
        }
    }
}