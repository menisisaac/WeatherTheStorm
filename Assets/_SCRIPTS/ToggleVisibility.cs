using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject woodWall;
    public GameObject stoneWall;
    public GameObject steelWall;

    void Start() {
        // Everything is disabled on start
        woodWall.SetActive(false);
        stoneWall.SetActive(false);
        steelWall.SetActive(false);
    }

    public void UpdateVisibility(string wallType)
    {
        // Disable all walls initially
        woodWall.SetActive(false);
        stoneWall.SetActive(false);
        steelWall.SetActive(false);

        // Enable the selected wall
        switch (wallType)
        {
            case "wood_wall":
                woodWall.SetActive(true);
                break;
            case "stone_wall":
                stoneWall.SetActive(true);
                break;
            case "steel_wall":
                steelWall.SetActive(true);
                break;
            default:
                Debug.LogWarning("Unsupported wall type specified: " + wallType);
                break;
        }
    }
}