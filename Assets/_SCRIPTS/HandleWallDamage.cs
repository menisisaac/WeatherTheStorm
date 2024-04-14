using System.Runtime.CompilerServices;
using UnityEngine;
using System;

public class HandleWallDamage : MonoBehaviour
{
    public GameObject woodWall;
    public GameObject stoneWall;
    public GameObject steelWall;

    public GameManager levelController; // Reference to the GameManager, set this in the Unity Inspector
    public GameObject disaster;
    private float probability = 0;
    private bool DoesWallFall()
    {
        // Check which wall is currently active.
        // Level is already stored.
        // Main difficulty is knowing which event occured (fire or flood).


        // Hard-coded probability values for now but should depend on level as well
        // Need to find a way to properly extract the level integer value
        if (woodWall.activeSelf) {
            if (disaster.name.Contains("tsunami")) {
                probability = 0.5f;
            } else {
                probability = 0.8f;
            }
        }
        if (stoneWall.activeSelf) {
            if (disaster.name.Contains("tsunami")) {
                probability = 0.5f;
            } else {
                probability = 0.2f;
            }
        }
        if (steelWall.activeSelf) {
            if (disaster.name.Contains("tsunami")) {
                probability = 0.2f;
            } else {
                probability = 0.3f;
            }
        }
        System.Random rand = new System.Random(); 
        if (rand.NextDouble() < probability) {
            return true;
        }
        return false;
    }
}
