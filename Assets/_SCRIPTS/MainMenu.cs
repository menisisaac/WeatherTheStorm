using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{

    private Button startButton;
    private Button exitButton;

    private GameObject houseControllerUICanvas;
    private GameObject mainMenuCanvas;
    private GameObject faderCanvas;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit button clicked! :D");
    }
}
