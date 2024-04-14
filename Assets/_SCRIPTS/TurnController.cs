using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnController : MonoBehaviour
{
    // pre start
    private int TurnValue; // get
    [SerializeField]
    private GameObject TurnTextObject;
    [SerializeField]
    private TMP_Text TurnText;



    // Start is called before the first frame update
    void Start()
    {
        TurnValue = 1;// intialize Turn
        


    }

    // Update is called once per frame
    void Update()
    {
        TurnText.text = TurnValue.ToString();
    }


    public void IncrimentTurn(int value)
    {
        TurnValue += value;
        SceneManager.LoadScene("cloud background");
        // call other methods her (ie: natural disasters)
        
    }

    public void Turn() 
    { 
        
    }
}
