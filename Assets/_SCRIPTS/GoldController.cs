using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{
    // pre start
    private int Gold; // get
    [SerializeField]
    private GameObject GoldTextObject;
    [SerializeField]
    private TMP_Text GoldText;


    // Start is called before the first frame update
    void Start()
    {
        Gold = 0;// intialize gold
        GoldText.text = Gold.ToString();

        // per turn = 10 gold


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
