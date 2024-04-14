using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject houseControllerUICanvas;
    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
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
        houseControllerUICanvas.SetActive(true);
        faderCanvas.SetActive(false);// potentally fade out over time, turn opacity to 0 over time
        this.mainMenuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit button clicked! :D");
    }
}
