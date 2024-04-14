using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TurnController : MonoBehaviour
{
    // pre start
    private int Turn; // get
    [SerializeField]
    private GameObject TurnTextObject;
    [SerializeField]
    private TMP_Text TurnText;


    // Start is called before the first frame update
    void Start()
    {
        Turn = 0;// intialize Turn
        TurnText.text = Turn.ToString();


    }

    // Update is called once per frame
    void Update()
    {

    }
}
